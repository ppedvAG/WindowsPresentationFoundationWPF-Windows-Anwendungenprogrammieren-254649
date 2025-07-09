using System.Windows;
using System.Windows.Media;

namespace M011;

public partial class MainWindow : Window
{
	public Color PickedColor { get; set; } = Colors.ForestGreen;

	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{

    }
}