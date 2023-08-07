namespace Pathfinder.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
		[ObservableProperty]
		private Character _character = new Character(
			"Floki",
			new List<AbilityScore>(){
				new AbilityScore(AbilityScoreEnum.Strength, 10, 0, 0),
				new AbilityScore(AbilityScoreEnum.Dexterity, 10, 0, 0),
				new AbilityScore(AbilityScoreEnum.Constitution, 10, 0, 0),
				new AbilityScore(AbilityScoreEnum.Wisdom, 10, 0, 0),
				new AbilityScore(AbilityScoreEnum.Intelligence, 10, 0, 0),
				new AbilityScore(AbilityScoreEnum.Charisma, 10, 0, 0)
				},
			new Race(),
			new SkillManager(),
			10);

		[ObservableProperty]
        private String _text = "Hello World";
    }
}
