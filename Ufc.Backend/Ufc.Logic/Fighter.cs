using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ufc.Logic
{
    public class Fighter
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Fighter(string name, int id) 
        { 
            Name = name;
            Id = id;
        }
    }
}
