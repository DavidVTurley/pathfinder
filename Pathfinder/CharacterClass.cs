using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder
{
    internal interface CharacterClass
    {
        public String ClassName { get; }
        public List<SkillData> Skills { get; }

        
    }
}
