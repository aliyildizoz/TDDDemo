using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.Tests
{

    [TestClass]
    public class GrouperRefactorTestV2
    {
        public List<Measurement> CreateMeasurements(int quantity)
        {
            var measurements = new List<Measurement>();
            for (int i = 1; i <= quantity; i++)
            {
                measurements.Add(new Measurement { Max = 10, Min = 1 });
            }

            return measurements;
        }
        [TestMethod]
        [Description("When a list with one item is grouped by one, the group count must be one")]
        public void GroupV1()
        {
            var measurements = new List<Measurement>
            {
                new Measurement
                {
                    Max=10,
                    Min=1
                }
            };

            var grouper = new GrouperRefactorV2(1);
            List<List<Measurement>> result = grouper.Group(measurements);

            Assert.AreEqual(1, result.Count);
        }
        [TestMethod]
        [Description("When a list with six item is grouped by two, the group count must be three")]
        public void GroupV2()
        {
            var measurements = new List<Measurement>
            {
                new Measurement {Max=10, Min=1},
                new Measurement {Max=10, Min=1},
                new Measurement {Max=10, Min=1},
                new Measurement {Max=10, Min=1},
                new Measurement {Max=10, Min=1},
                new Measurement {Max=10, Min=1}
            };

            var grouper = new GrouperRefactorV2(2);
            List<List<Measurement>> result = grouper.Group(measurements);

            Assert.AreEqual(3, result.Count);
        }
        [TestMethod]
        [Description("When a list with twenty four item is grouped by five, the group count must be four")]
        public void GroupV3()
        {

            var grouper = new GrouperRefactorV2(5);
            List<List<Measurement>> result = grouper.Group(CreateMeasurements(24));

            Assert.AreEqual(5, result.Count);
        }
    }
}
