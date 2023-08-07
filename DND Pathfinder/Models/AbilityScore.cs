namespace DND_Pathfinder.Models
{
    public partial class AbilityScore : ObservableObject
    {
        [ObservableProperty]
        private AbilityScoreTypeEnum _type; 

		public Int32 Score => BaseScore + Temp + Misc;

        [ObservableProperty]
        Int32 _baseScore = 10;
        [ObservableProperty]
        Int32 _temp = 0;
        [ObservableProperty]
        Int32 _misc = 0;

		public AbilityScore(AbilityScoreTypeEnum type = default, int baseScore = 10, int temp = 0, int misc = 0)
		{
			Type = type;
			BaseScore = baseScore;
			Temp = temp;
			Misc = misc;
		}

		public enum AbilityScoreTypeEnum
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
				new AbilityScore(AbilityScore.AbilityScoreTypeEnum.Strength),
				new AbilityScore(AbilityScore.AbilityScoreTypeEnum.Dexterity),
				new AbilityScore(AbilityScore.AbilityScoreTypeEnum.Constitution),
				new AbilityScore(AbilityScore.AbilityScoreTypeEnum.Wisdom),
				new AbilityScore(AbilityScore.AbilityScoreTypeEnum.Intelligence),
				new AbilityScore(AbilityScore.AbilityScoreTypeEnum.Charisma)
			};
		}
	}
}
