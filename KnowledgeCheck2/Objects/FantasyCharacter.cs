using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2.Objects
{
    internal class FantasyCharacter : Character
    {
        public string Race { get; set; }
        public string Class { get; set; } 
        public int Level { get; set; }

        public FantasyCharacter()
        {
            Level = 0;
        }
    }
}
