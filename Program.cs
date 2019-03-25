using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Type consoleType = typeof(Console);
            foreach (var type in consoleType.GetMembers())
            {
                if (type is MethodInfo)
                {
                    Console.WriteLine(type);
                }
            }
            Console.WriteLine();
            User user = new User()
            {
                Id = 123,
                Login = "Ruslan", 
                Password = "qwerty123"
            };
            Type userType = typeof(User);
            foreach (var type in userType.GetProperties())
            {
                Console.WriteLine(type + " - " + type.GetValue(user));
            }
        }
    }
}
