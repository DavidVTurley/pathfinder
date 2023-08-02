using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder;

public class Character
{
    public Int32 Strength;
    public Int32 Dexterity;
    public Int32 Constitution;
    public Int32 Wisdom;
    public Int32 Intellect;
    public Int32 Charisma;

    public Int32 Hitpoints;

    public Race Race;
    public SkillManager Skills;
    public Class Class;
    // Race
    //   Ability Mods
    //   Traits
    // Class
    //   Hit Dice
    // Feats
    // 
    public Character(int strength, int dexterity, int constitution, int wisdom, int intellect, int charisma, Race race, SkillManager skills, int hitpoints)
    {
        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Wisdom = wisdom;
        Intellect = intellect;
        Charisma = charisma;
        Race = race;
        Skills = skills;
        Hitpoints = hitpoints;
    }
}
