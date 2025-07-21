namespace Enums
{
    internal class Program
    {
        public enum Season { WINTER, SPRING, SUMMER, FALL}
        static void Main(string[] args)
        {
           int x = (int)Season.WINTER;
            int y = (int)Season.SUMMER;
            Console.WriteLine("WINTER = {0}", x);
            Console.WriteLine("SUMMER = {0}", y);

            //using GetNames() method
            foreach(string s in Enum.GetNames(typeof(Season)))
            {
                Console.WriteLine(s);
            }

            //using GetValues() method
            foreach(string s in Enum.GetValues(typeof(Season)))
            {
                Console.WriteLine(s);
            }

        }
    }
}
