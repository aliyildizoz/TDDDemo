using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.Tests
{
    [TestClass]
    public class GrouperGreenTest
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

            var grouper = new GrouperGreen(1);
            List<List<Measurement>> result = grouper.Group(measurements);

            Assert.AreEqual(1, result.Count);
        }
    }
}
