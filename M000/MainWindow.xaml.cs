using System.Windows;
using System.Windows.Media;

namespace M000;

public partial class MainWindow : Window
{
	public Person DiePerson { get; set; } = new() { Lieblingsfarbe = Colors.Aqua };

	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{

	}
}