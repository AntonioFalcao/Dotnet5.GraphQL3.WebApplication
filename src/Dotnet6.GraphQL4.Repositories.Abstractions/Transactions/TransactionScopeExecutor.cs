﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace Dotnet6.GraphQL4.Repositories.Abstractions.Transactions
{
    public class TransactionScopeExecutor<T>
    {
        private TransactionScopeOption _scopeOption;
        private TransactionScopeAsyncFlowOption _asyncFlowOption;
        
        private Func<bool> _condition;
        private Func<CancellationToken, Task<bool>> _conditionAsync;

        private readonly TransactionOptions _transactionOptions;
        private readonly Func<T> _operation;
        private readonly Func<CancellationToken, Task<T>> _operationAsync;

        public TransactionScopeExecutor() { }
        
        public TransactionScopeExecutor(Func<T> operation)
        {
            _operation = operation;
        }

        public TransactionScopeExecutor(Func<CancellationToken, Task<T>> operationAsync)
        {
            _operationAsync = operationAsync;
        }

        public TransactionScopeExecutor<T> WithScopeOption(TransactionScopeOption scopeOption = TransactionScopeOption.Required)
        {
            _scopeOption = scopeOption;
            return this;
        }

        public TransactionScopeExecutor<T> WithOptions(Action<TransactionOptions> actionTransactionOptions)
        {
            actionTransactionOptions(_transactionOptions);
            return this;
        }

        public TransactionScopeExecutor<T> WithScopeAsyncFlowOption(TransactionScopeAsyncFlowOption asyncFlowOption = TransactionScopeAsyncFlowOption.Enabled)
        {
            _asyncFlowOption = asyncFlowOption;
            return this;
        }

        public TransactionScopeExecutor<T> WithCondition(Func<bool> condition)
        {
            _condition = condition;
            return this;
        }
        
        public TransactionScopeExecutor<T> WithConditionAsync(Func<CancellationToken, Task<bool>> conditionAsync)
        {
            _conditionAsync = conditionAsync;
            return this;
        }

        public T Execute(Func<T> operation)
        {
            using var scope = CreateScope();
            var result = operation();
            if (_condition()) scope.Complete();
            return result;
        }

        public T Execute()
        {
            using var scope = CreateScope();
            var result = _operation();
            
            if (_condition()) 
                scope.Complete();
            
            return result;
        }

        public async Task<T> ExecuteAsync(CancellationToken cancellationToken)
        {
            using var scope = CreateScope();
            var result = await _operationAsync(cancellationToken);
            
            if (await _conditionAsync(cancellationToken)) 
                scope.Complete();
            
            return result;
        }
        
        public async Task<T> ExecuteAsync(Func<CancellationToken, Task<T>> operationAsync, CancellationToken cancellationToken)
        {
            using var scope = CreateScope();
            var result = await operationAsync(cancellationToken);
            
            if (await _conditionAsync(cancellationToken)) 
                scope.Complete();
            
            return result;
        }

        private TransactionScope CreateScope()
            => new(
                scopeOption: _scopeOption, 
                transactionOptions: _transactionOptions, 
                asyncFlowOption: _asyncFlowOption);
    }
}