using System.Windows;

namespace M002;

public partial class MainWindow : Window
{
	public List<int> Zahlen = [1, 2, 3, 4, 5];

	public MainWindow()
	{
		InitializeComponent();

		Dropdown.ItemsSource = Zahlen;
		IC.ItemsSource = Zahlen;
	}

	private void HalloWeltClicked(object sender, RoutedEventArgs e)
	{
		MessageBox.Show("Servus");
	}
}