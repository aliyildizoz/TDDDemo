using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class GrouperRefactorV1
    {
        private int _groupCount;

        public GrouperRefactorV1(int groupCount)
        {
            this._groupCount = groupCount;
        }

        public List<List<Measurement>> Group(List<Measurement> measurements)
        {
            var groups = new List<List<Measurement>>();
            if (_groupCount >= measurements.Count)
            {
                groups.Add(measurements);
                return groups;
            }


            var diff = measurements.Count % _groupCount;
            var count = measurements.Count - (diff == 0 ? 0 : diff);
            
            for (int i = 0; i < count; i++)
            {
                if ((i + 1) % _groupCount == 0)
                {
                    groups.Add(new List<Measurement>(measurements.GetRange(i + 1 - _groupCount, _groupCount)));
                }
            }

            if (diff == 0) groups.Add(new List<Measurement>(measurements.GetRange(measurements.Count - diff - 1, diff)));

            return groups;
        }

    }
}
