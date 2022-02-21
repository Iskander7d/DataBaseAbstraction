using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAbstraction
{
    // operation with database entities
    class Operation
    {
        private string allowedOperation;
        public string AllowedOperation
        {
            get { return allowedOperation; }
            set { allowedOperation = value; }
        }

        public virtual void Description()
        {
            Console.WriteLine("For user allowed operation {0}", AllowedOperation);
        }

    }

    class Read : Operation
    {
        public override void Description()
        {
            base.Description();
            Console.WriteLine("Only for getting data from entities");
        }
    }

    class Write : Operation
    {
        public override void Description()
        {
            base.Description();
            Console.WriteLine("Only for setting data to Entities fields");
        }
    }

    class Edit : Operation
    {
        public override void Description()
        {
            base.Description();
            Console.WriteLine("Allows edit existing data in entity");
        }
    }

    class Delete : Edit
    {
        public override void Description()
        {
            base.Description();
            Console.WriteLine("Allows delete data from entities");
        }
    }
}
