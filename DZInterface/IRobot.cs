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
        public string GetRobotType() => "I am a simple robot.";
        
        public List<string> GetComponents();
    }
}
