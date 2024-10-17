using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;

namespace DZInterface
{
    internal class Quadcopter: IFlyingRobot , IChargeable
    {
        
        List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

        public List<string> Components { get => _components; set => _components = value; }

        public string GetRobotType()
        {
            return ((IFlyingRobot)this).GetRobotType();
        }
        
        public string GetInfo()
        {
            return "";
        }       

        
        public List<string> GetComponents()
        {            
           return Components;            
        }
        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged");
        }
    }
}
