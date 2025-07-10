using System.Windows.Input;

namespace M013;

public class CustomCommand : ICommand
{
	/// <summary>
	/// Action: Methodenzeiger, welche void zurückgibt und bis zu 16 Parameter hat
	/// In MainWindow.xaml.cs wird ein Methodenzeiger an dieses Objekt weitergegeben
	/// </summary>
	private Action<object?> executeMethod;

	/// <summary>
	/// Func: Methodenzeiger, welche einen beliebigen Rückgabewert und bis zu 16 Parameter hat
	/// In MainWindow.xaml.cs wird ein Methodenzeiger an dieses Objekt weitergegeben
	/// </summary>
	private Func<object?, bool> canExecuteMethod;

	public CustomCommand(Action<object?> exe, Func<object?, bool> canExe = null)
	{
		executeMethod = exe;
		canExecuteMethod = canExe;
	}

	public event EventHandler? CanExecuteChanged;

	public void Execute(object? parameter)
	{
		executeMethod?.Invoke(parameter);
		//executeMethod(parameter);
	}

	public bool CanExecute(object? parameter)
	{
		return canExecuteMethod != null ? canExecuteMethod.Invoke(parameter) : true;
	}
}
