using System.Linq;
using System.Windows;

namespace M015;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		//if (Thread.CurrentThread.CurrentUICulture.Name != "en-US")
		//	Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
		//else
		//	Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");

		///////////////////////////////////////////////////////////////////////////////////////

		string path = "pack://application:,,,/Localisation/Strings-#.xaml";
		Uri uri = new Uri(path.Replace("#", Sprachauswahl.Text));

		ResourceDictionary rd = new();
		rd.Source = uri;

		App.Current.Resources.MergedDictionaries.Clear();
		App.Current.Resources.MergedDictionaries.Add(rd);
	}
}