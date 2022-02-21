using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAbstraction
{
    class Entity
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Type;
        public string Content;

        public Entity(int id, string type, string content)
        {
            Id = id;
            Type = type;
            Content = content;
        }

        public string Formatted()
        {
            String formatted = String.Format("{0},\n{1},\n{2}\n", Id, Type, Content);
            return formatted;
        }
    }
}
