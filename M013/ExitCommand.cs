using System.Windows.Input;

namespace M013;

public class ExitCommand : ICommand
{
	public event EventHandler? CanExecuteChanged;

	/// <summary>
	/// Methode, welche beim Button-Click ausgeführt wird
	/// </summary>
	public void Execute(object? parameter)
	{
		Environment.Exit(0);
	}

	/// <summary>
	/// Aktiviert/Deaktiviert den Button (IsEnabled)
	/// </summary>
	public bool CanExecute(object? parameter)
	{
		return true;
	}
}
