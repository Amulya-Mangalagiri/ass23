using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssesmentLib
{
    public class LoginOperator
    {
        static List<Login> list = new List<Login>()
        {
            new Login {ID = 123456,Password = "qwerty"},
            new Login {ID = 111111,Password = "qwerty"},
            new Login {ID = 222222,Password = "qwerty"},
            new Login {ID = 333333,Password = "qwerty"},
            new Login {ID = 444444,Password = "qwerty"},
        };
        public static void login()
        {
            Login loginDetails = new Login();
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            Login l = list.SingleOrDefault(e => e.ID == id && e.Password == password);
            if (l != null)
            {
                Console.WriteLine("Login Successfull!!");
            }
            else
            {
                Console.WriteLine("Invalid Details!!");
            }

        }
    }
}