using System.Windows;
using System.Windows.Input;

namespace M013;

public partial class MainWindow : Window
{
	public ExitCommand Exit { get; set; } = new();

	public CounterCommand Counter { get; set; } = new();

	public CustomCommand CounterCustom { get; set; }

	public CustomCommand EingabeCommand { get; set; }

	public WrappedInt Zaehler { get; set; } = new();

	public string Eingabe { get; set; }

	public MainWindow()
	{
		CounterCustom = new CustomCommand(CounterPlusOne);
		EingabeCommand = new CustomCommand(EnterPressed);
		
		InitializeComponent();
	}

	public void CounterPlusOne(object? parameter)
	{
		Zaehler.Value++;
	}

	public void EnterPressed(object? parameter)
	{
		if (parameter is KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				//...

				MessageBox.Show(Eingabe);
			}
		}
	}
}

public class WrappedInt
{
	public int Value { get; set; }
}