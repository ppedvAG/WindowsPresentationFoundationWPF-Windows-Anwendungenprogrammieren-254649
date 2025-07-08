using System.Windows;

namespace M008;

public partial class MainWindow : Window
{
	public DayOfWeek[] Wochentage { get; set;  } = Enum.GetValues<DayOfWeek>();

	public MainWindow()
	{
		InitializeComponent();
	}
}