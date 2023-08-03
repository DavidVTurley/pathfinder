using CommunityToolkit.Mvvm.ComponentModel;

namespace Pathfinder;

public partial class SkillManager : ObservableObject
{
    [ObservableProperty]
    public Dictionary<Skill, SkillData> skills = new();


    public SkillManager()
    {

    }
    public SkillManager(Dictionary<Skill, SkillData> skills)
    {
        this.skills = skills;
    }



    public SkillData GetSkill(Skill skill)
    {
        return skills[skill];
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
