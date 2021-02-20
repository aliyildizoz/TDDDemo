using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Demo.Tests
{
    [TestClass]
    public class GrouperRedTest
    {
        [TestMethod]
        public void Group()
        {
            var measurements = new List<Measurement>
            {
                new Measurement
                {
                    Max=10,
                    Min=1
                }
            };

            var grouper = new GrouperRed(1);
            List<List<Measurement>> result = grouper.Group(measurements);

            Assert.AreEqual(1, result.Count);
        }
    }
}
