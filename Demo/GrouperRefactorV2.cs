using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class GrouperRefactorV2
    {
        private int _groupCount;

        public GrouperRefactorV2(int groupCount)
        {
            this._groupCount = groupCount;
        }

        public List<List<Measurement>> Group(List<Measurement> measurements)
        {
            var groups = new List<List<Measurement>>();
            for (int i = 0; i < measurements.Count;)
            {
                var group = measurements.Skip(i).Take(_groupCount).ToList();
                groups.Add(group);
                i += _groupCount;
            }
            return groups;
        }
    }
}
