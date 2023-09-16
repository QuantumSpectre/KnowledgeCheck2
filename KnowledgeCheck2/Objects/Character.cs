using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnowledgeCheck2.Objects
{
    internal class Character
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100.")]
        public int Age { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return Name + ": " + Description + " \n";
        }
    }

    
}
