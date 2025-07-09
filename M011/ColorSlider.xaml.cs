using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace M011;

public partial class ColorSlider : UserControl
{
	public ColorSlider()
	{
		InitializeComponent();
	}

	#region ColorText
	public string ColorText
	{
		get => (string) GetValue(ColorTextProperty);
		set => SetValue(ColorTextProperty, value);
	}

	public static readonly DependencyProperty ColorTextProperty =
		DependencyProperty.Register
		(
			nameof(ColorText), //Name des Properties
			typeof(string), //Typ des Properties
			typeof(ColorSlider), //Typ der Klasse
			new PropertyMetadata(string.Empty) //Einstellungen
		);
	#endregion

	#region TextColor
	public Color TextColor
	{
		get => (Color) GetValue(TextColorProperty);
		set => SetValue(TextColorProperty, value);
	}

	public static readonly DependencyProperty TextColorProperty =
		DependencyProperty.Register
		(
			nameof(TextColor),
			typeof(Color),
			typeof(ColorSlider),
			new PropertyMetadata(Colors.Black)
		);
	#endregion

	#region SliderValue
	public byte SliderValue
	{
		get => (byte) GetValue(SliderValueProperty);
		set => SetValue(SliderValueProperty, value);
	}

	public static readonly DependencyProperty SliderValueProperty =
		DependencyProperty.Register
		(
			nameof(SliderValue),
			typeof(byte),
			typeof(ColorSlider),
			new PropertyMetadata((byte) 0)
		);
	#endregion
}