using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder;

public class SkillManager
{
    public Dictionary<Skill, SkillData> Skills { get; set; } = new();


    public SkillManager()
    {

    }
    public SkillManager(Dictionary<Skill, SkillData> skills)
    {
        Skills = skills;
    }



    public SkillData GetSkill(Skill skill)
    {
        return Skills[skill];
    }
}

public enum Skill
{
    Acrobatics,
    Appraise,
    Bluff,
    Climb,
    Craft,
    Diplomacy,
    Disable_Device,
    Disguise,
    Escape_Artist,
    Fly,
    Handle_Animal,
    Heal,
    Intimidate,
    Knowledge_arcana,
    Knowledge_dungeoneering,
    Knowledge_engineering,
    Knowledge_geography,
    Knowledge_history,
    Knowledge_local,
    Knowledge_nature,
    Knowledge_nobility,
    Knowledge_planes,
    Knowledge_religion,
    Linguistics,
    Perception,
    Perform,
    Profession,
    Ride,
    Sense_Motive,
    Sleight_of_Hand,
    Spellcraft,
    Stealth,
    Survival,
    Swim,
    Use_Magic_Device,
}
public struct SkillData
{
    public Int32 Ranks;
    public Int32 Misc;
    public Int32 Temp;
}
