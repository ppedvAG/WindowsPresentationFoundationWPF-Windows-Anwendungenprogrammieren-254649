using M014.Utility;

namespace M014.ViewModel;

/// <summary>
/// Diese Klasse fungiert als Backend-Klasse für MainWindow.xaml
/// Hier können jetzt Variablen/Methoden/Konstruktoren angelegt werden
/// Per Binding kann im Frontend auf Member innerhalb dieser Klasse zugegriffen werden
/// </summary>
public class MainWindowViewModel : ViewModelBase
{
	public string Hallo { get; set; }

	public CustomCommand ExitCommand { get; set; }

	/// <summary>
	/// Am Start der Anwendung wird dieser Konstruktor ausgeführt
	/// </summary>
	public MainWindowViewModel()
	{
		Hallo = "Hallo Welt!";
		ExitCommand = new CustomCommand(Exit);
	}

	public void Exit(object? p)
	{
		Environment.Exit(0);
	}
}