using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class GrouperGreen
    {
        private int v;

        public GrouperGreen(int v)
        {
            this.v = v;
        }

        public List<List<Measurement>> Group(List<Measurement> measurements)
        {
            return new List<List<Measurement>> { measurements };
        }
    }
}
