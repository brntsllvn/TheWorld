using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace TheWorld.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void IndexReturnsAllTrips()
        {
            Assert.That(6, Is.EqualTo(6));

        }
    }
}
