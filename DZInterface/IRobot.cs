using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZInterface
{
    internal interface IRobot
    {
        public string GetInfo();
        public string GetRobotType();
        public List<string> GetComponents();
    }
}
