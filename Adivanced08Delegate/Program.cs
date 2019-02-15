using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivanced08Delegate
{
    class Program
    {
        public delegate void InformationDel();
        public delegate void InformationWithNameDel(string name);
        public delegate void InformationwithNameGoalDel(string name, int goal);
        public delegate string InformationNumberDel(int nummber);
        static void Main(string[] args)
        {
          InformationDel info = new InformationDel(DisplayInformation);
            info.Invoke();
            InformationWithNameDel infoName = new InformationWithNameDel(DisplayInformation);
            infoName("Ronaldnho");
            InformationwithNameGoalDel infoNameGoal = new InformationwithNameGoalDel(DisplayInformation);
            infoNameGoal("Ronaldnho",11);
            InformationNumberDel infonum = new InformationNumberDel(InformationNumber);
            Console.WriteLine(infonum(7));

            Console.WriteLine("--More about delegate--");
            Console.WriteLine(infonum.Method);
            foreach (var item in infonum.Method.GetParameters())
            {
                Console.WriteLine($"{ item.ParameterType.Name}\n{item.Name}\n{item.Position}\n{item.DefaultValue}");
            }
            Console.WriteLine("------------------------");

            Console.ReadKey();
        }
        static void DisplayInformation()
        {
            Console.WriteLine("Informaton About Player : Renaldinho");
        }
        static public void DisplayInformation(string name)
        {
            Console.WriteLine("Information about Player : "+name);
        }
        static void DisplayInformation(string name , int goal)
        {
            Console.WriteLine("Information about Player : "+name+" and score "+goal);
        }
        static string InformationNumber(int number)
        {
            string num = string.Empty;
            switch (number)
            {
                case 7 : num = "Ronaldnho";
                    break;
                case 8:  num = "Messi";
                    break;

                case 10: num = "Rooney";
                    break;
                default:num = "no one";
                    break;
            }
            return num;
        }
    }
}
