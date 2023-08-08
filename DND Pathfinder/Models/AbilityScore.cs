namespace DND_Pathfinder.Models
{
    public partial class AbilityScore : ObservableObject
    {
        [ObservableProperty]
        private AbilityScoreType _type; 

		public Int32 Score => BaseScore + Temp + Misc;

        [ObservableProperty]
        Int32 _baseScore = 10;
        [ObservableProperty]
        Int32 _temp = 0;
        [ObservableProperty]
        Int32 _misc = 0;

		public AbilityScore(AbilityScoreType type = default, int baseScore = 10, int temp = 0, int misc = 0)
		{
			Type = type;
			BaseScore = baseScore;
			Temp = temp;
			Misc = misc;
		}

		public enum AbilityScoreType
		{
			Strength,
			Dexterity,
			Constitution,
			Wisdom,
			Intelligence,
			Charisma,
		}

		public static List<AbilityScore> GetBaseAbilityScoreSheet()
		{
			return new List<AbilityScore>()
			{
				new AbilityScore(AbilityScore.AbilityScoreType.Strength),
				new AbilityScore(AbilityScore.AbilityScoreType.Dexterity),
				new AbilityScore(AbilityScore.AbilityScoreType.Constitution),
				new AbilityScore(AbilityScore.AbilityScoreType.Wisdom),
				new AbilityScore(AbilityScore.AbilityScoreType.Intelligence),
				new AbilityScore(AbilityScore.AbilityScoreType.Charisma)
			};
		}
	}
}
