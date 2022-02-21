using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAbstraction
{
    class User
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Role role;
        public Role Role
        {
            get { return role; }
            set { role = value; }
        }

        public User(string name, string role)
        {
            Name = name;
            if (role == "admin")
            {
                List<Operation> adminOps = new List<Operation>()
                {
                    new Read { AllowedOperation = "read" },
                    new Write { AllowedOperation = "write" },
                    new Edit { AllowedOperation = "edit" },
                    new Delete { AllowedOperation = "delete" }
                };
                Role = new Admin(role, adminOps);
            }
            if (role == "guest")
            {
                List<Operation> guestOps = new List<Operation>()
                {
                    new Read { AllowedOperation = "read" }
                };
                Role = new Guest(role, guestOps);
            }
            if (role == "worker")
            {
                List<Operation> workerOps = new List<Operation>()
                {
                    new Read { AllowedOperation = "read" },
                    new Write { AllowedOperation = "write" }
                };
                Role = new Worker(role, workerOps);
            }
            Console.WriteLine("Welcome, {0} with role {1}!", Name, role);
        }

        public Entity CreateEntity(int id, string type, string content)
        {
            foreach (var op in Role.AllowedOperations)
            {
                if (op.AllowedOperation == "write")
                {
                    return new Entity(id, type, content);
                }
            }
            Write writeOperation = new Write();
            writeOperation.Description();
            return null;
        }
    }
}
