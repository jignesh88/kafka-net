﻿using KafkaNet.Protocol;
using NUnit.Framework;


namespace kafka_tests
{
    [TestFixture]
    [Category("Unit")]
    public class ProtocolBaseRequestTests
    {
        [Test]
        public void EnsureHeaderShouldPackCorrectByteLengths()
        {
            var result = BaseRequest.EncodeHeader(new FetchRequest { ClientId = "test", CorrelationId = 123456789 });

            Assert.That(result.Length, Is.EqualTo(14));
            Assert.That(result, Is.EqualTo(new byte[] { 0, 1, 0, 0, 7, 91, 205, 21, 0, 4, 116, 101, 115, 116 }));
        }
    }
}
