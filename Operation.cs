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
        // Пример инкапсуляции. У тебя приватная переменная allowedOperaion,
        // А ее изменение и получения осуществляется через публичный AllowedOperaion метод
        private string allowedOperation;
        public string AllowedOperation
        {
            get { return allowedOperation; }
            set { allowedOperation = value; }
        }

        // Пример полиморфизма. В базовом классе создается виртуальный метод Discription.
        // А в наследуемых классах он переопределяется. Это и есть полиморфизм - множество форм.
        public virtual void Description()
        {
            Console.WriteLine("For user allowed operation {0}", AllowedOperation);
        }

    }

    // Пример наследования. У тебя иерархия классов операций. Есть базовая Operation, от неё
    // наследуется Read, Write, Edit, а Delete от Edit.
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
