using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace M012;

public partial class MainWindow : Window
{
	public ObservableCollection<Person> Personen { get; set; } = [];

	public MainWindow()
	{
		InitializeComponent();

		string str = File.ReadAllText("Personen.json");
		List<Person> p = JsonSerializer.Deserialize<List<Person>>(str);
		foreach (Person person in p)
			Personen.Add(person);
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Button b = (Button) sender;
		Person p = (Person)b.DataContext;
		Personen.Remove(p);
	}
}