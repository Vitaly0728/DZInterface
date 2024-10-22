namespace DZInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var components= new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };
            var quadcopter = new Quadcopter(("Kopter"), components);

            Console.WriteLine(quadcopter.GetInfo());
            foreach(var component in quadcopter.GetComponents())
            {
                Console.WriteLine(component.ToString());
            }

            Console.WriteLine(((IFlyingRobot)quadcopter).GetRobotType());

            quadcopter.Charge();            

        }
    }
}
