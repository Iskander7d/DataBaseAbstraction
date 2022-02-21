using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAbstraction
{
    class Role
    {
        private string userRole;
        public string UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }

        private List<Operation> allowedOperations;
        public List<Operation> AllowedOperations
        {
            get { return allowedOperations; }
            set { allowedOperations = value; }
        }
    }

    class Admin : Role
    {
        public Admin(string role, List<Operation> operations)
        {
            UserRole = role;
            AllowedOperations = operations;
        }
    }

    class Guest : Role
    {
        public Guest(string role, List<Operation> operations)
        {
            UserRole = role;
            AllowedOperations = operations;
        }
    }

    class Worker : Role
    {
        public Worker(string role, List<Operation> operations)
        {
            UserRole = role;
            AllowedOperations = operations;
        }
    }
}
