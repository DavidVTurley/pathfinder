using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder
{
    public class Race
    {
        public Dictionary<String, Int32> RaceAbilityModifiers = new();
        public Dictionary<String, Int32> RaceSkillModifiers = new();

        public Race() { }
        public Race(Dictionary<string, int> raceSkillModifiers, Dictionary<string, int> raceAbilityModifiers)
        {
            RaceSkillModifiers = raceSkillModifiers;
            RaceAbilityModifiers = raceAbilityModifiers;
        }
    }
}
