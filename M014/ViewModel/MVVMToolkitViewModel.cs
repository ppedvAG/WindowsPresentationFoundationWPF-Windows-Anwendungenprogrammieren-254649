using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace M014.ViewModel;

/// <summary>
/// MVVMToolkit existiert generell nur im C# Code
/// Die ViewModel Klasse MUSS von ObservableObject erben
/// Klasse muss partial sein (da im Hintergrund Code erzeugt wird)
/// </summary>
public partial class MVVMToolkitViewModel : ObservableObject
{
	[ObservableProperty]
	private int counter;

	[RelayCommand]
	public void Increment(object o)
	{
		Counter++;
	}
}