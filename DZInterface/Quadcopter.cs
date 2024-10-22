

namespace DZInterface
{
    internal class Quadcopter: IFlyingRobot , IChargeable
    {
        
        private List<string> _components = new List<string> {};
        private string _infoQuadcopter;


        public Quadcopter(string info, List<string> components)
        {
            _components = components;
            _infoQuadcopter = info;
        }

        public string GetRobotType() => "I am a flying Quadcopter.";

        public string GetInfo()
        {
            return _infoQuadcopter;
        }    
        
        public List<string> GetComponents()
        {            
           return _components;            
        }
        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged");
        }
    }
}
