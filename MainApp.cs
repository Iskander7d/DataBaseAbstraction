using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAbstraction
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            if (name.Trim() == "")
            {
                Console.WriteLine("Invalid name!");
                return;
            }

            var possibleRoles = new string[] { "admin", "guest", "worker" };
            Console.WriteLine("Enter your role: ");
            var role = Console.ReadLine();
            if (!possibleRoles.Contains(role))
            {
                Console.WriteLine("Invalid role!");
                foreach (var possibleRole in possibleRoles)
                {
                    Console.Write("{0},\t", possibleRole);
                }
                return;
            }

            User user = new User(name, role);

            Entity newEntity = user.CreateEntity(1, "Customer", "My First Record");
            Console.WriteLine("{0}", newEntity.Formatted());


        }
    }
}
