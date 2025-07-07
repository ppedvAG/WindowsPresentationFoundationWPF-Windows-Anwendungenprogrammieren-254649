using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace M005;

public partial class MainWindow : Window, INotifyPropertyChanged
{
	private int counter = 5;

	public int Counter
	{
		get => counter;
		set
		{
			counter = value;
			Notify(nameof(Counter));
		}
	}

	//Wenn hier Elemente hinzugefügt/entfernt werden, wird die GUI benachrichtigt
	//WICHTIG: ObservableCollection niemals nach Initialisierung neu erstellen (immer mit .Clear() arbeiten)
	public ObservableCollection<int> Nummern { get; set; } = [];

	public MainWindow()
	{
		this.DataContext = this;

		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Counter++;
		//Notify(nameof(Counter));

		Nummern.Add(Random.Shared.Next());
	}

	//////////////////////////////////////////////////////////////////////////////

	public event PropertyChangedEventHandler? PropertyChanged;

	//Sendet die Benachrichtigung an die GUI
	public void Notify(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}