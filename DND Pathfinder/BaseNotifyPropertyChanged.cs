using CommunityToolkit.Mvvm.Input;
using DND_Pathfinder.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DND_Pathfinder;

	public class BaseNotifyPropertyChanged : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}