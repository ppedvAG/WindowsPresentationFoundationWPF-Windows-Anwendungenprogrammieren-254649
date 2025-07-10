using System.Windows.Input;

namespace M013;

public class CounterCommand : ICommand
{
	public event EventHandler? CanExecuteChanged;

	public void Execute(object? parameter)
	{
		if (parameter is WrappedInt x)
		{
			x.Value++;
		}
	}

	public bool CanExecute(object? parameter)
	{
		return parameter is WrappedInt x ? x.Value < 5 : true;
	}
}
