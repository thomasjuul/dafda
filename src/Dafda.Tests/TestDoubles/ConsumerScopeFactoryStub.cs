﻿using Dafda.Consuming;

namespace Dafda.Tests.TestDoubles
{
    internal class ConsumerScopeFactoryStub : IConsumerScopeFactory
    {
        private readonly ConsumerScope _result;

        public ConsumerScopeFactoryStub(ConsumerScope result)
        {
            _result = result;
        }

        public ConsumerScope CreateConsumerScope()
        {
            return _result;
        }
    }
}