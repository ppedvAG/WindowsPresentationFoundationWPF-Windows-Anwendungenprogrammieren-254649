using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace M009;

public partial class MainWindow : Window, INotifyPropertyChanged, IDataErrorInfo
{
	#region ValidationRules
	private string vollerName;

	public string VollerName
	{
		get => vollerName;
		set
		{
			vollerName = value;
			Notify();
		}
	}

	public string VollerName2 { get; set; }
	#endregion

	#region ValidateOnException
	private string vollerName3;

	public string VollerName3
	{
		get => vollerName3;
		set
		{
			if (value == null)
				throw new Exception("Gib einen Namen ein.");

			if (!value.All(char.IsLetter))
				throw new Exception("Name darf nur aus Buchstaben bestehen!");

			if (value.Length < 3 || value.Length > 15)
				throw new Exception("Name muss zw. 3 und 15 Zeichen haben!");

			vollerName3 = value;
			Notify();
		}
	}
	#endregion

	#region ValidateOnDataError
	private string vollerName4;

	public string VollerName4
	{
		get => vollerName4;
		set
		{
			vollerName4 = value;
			Notify();
		}
	}

	public string Error => "";

	/// <summary>
	/// Wenn hier null zurück kommt, ist es kein Fehler, sonst Fehler
	/// </summary>
	public string this[string propertyName]
	{
		get
		{
			switch (propertyName)
			{
				case nameof(VollerName4):
					if (VollerName4 == null)
						return "Gib einen Namen ein.";

					if (!VollerName4.All(char.IsLetter))
						return "Name darf nur aus Buchstaben bestehen!";

					if (VollerName4.Length < 3 || VollerName4.Length > 15)
						return "Name muss zw. 3 und 15 Zeichen haben!";

					return null;
			}

			return null; //Kein Fehler
		}
	}
	#endregion

	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{

	}

	#region INotifyPropertyChanged
	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
	#endregion
}