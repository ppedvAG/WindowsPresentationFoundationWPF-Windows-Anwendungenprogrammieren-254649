using M014.Model;
using M014.Utility;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace M014.ViewModel;

public class PersonenViewViewModel : ViewModelBase
{
	public ObservableCollection<Person> Personen { get; set; } = [];

	public CustomCommand DeletePersonCommand { get; set; }

	public PersonenViewViewModel()
	{
		DeletePersonCommand = new CustomCommand(DeletePerson);

		string str = File.ReadAllText("Personen.json");
		List<Person> p = JsonSerializer.Deserialize<List<Person>>(str);
		foreach (Person person in p)
			Personen.Add(person);
	}

	public void DeletePerson(object? par)
	{
		if (par is Person p)
		{
			Personen.Remove(p);
		}
	}
}