using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace M011;

public partial class ColorPickerUC : UserControl
{
	public ColorPickerUC()
	{
		InitializeComponent();
	}

	#region PickedColor
	public Color PickedColor
	{
		get => (Color) GetValue(PickedColorProperty);
		set => SetValue(PickedColorProperty, value);
	}

	public static readonly DependencyProperty PickedColorProperty =
		DependencyProperty.Register
		(
			nameof(PickedColor),
			typeof(Color),
			typeof(ColorPickerUC),
			new PropertyMetadata(Color.FromArgb(255, 0, 0, 0), PickedColorChanged)
		);
	#endregion

	#region R
	public byte R
	{
		get => (byte) GetValue(RProperty);
		set => SetValue(RProperty, value);
	}

	public static readonly DependencyProperty RProperty =
		DependencyProperty.Register
		(
			nameof(R),
			typeof(byte),
			typeof(ColorPickerUC),
			new PropertyMetadata((byte) 0, SliderValueChanged)
		);
	#endregion

	#region G
	public byte G
	{
		get => (byte) GetValue(GProperty);
		set => SetValue(GProperty, value);
	}

	public static readonly DependencyProperty GProperty =
		DependencyProperty.Register
		(
			nameof(G),
			typeof(byte),
			typeof(ColorPickerUC),
			new PropertyMetadata((byte) 0, SliderValueChanged)
		);
	#endregion

	#region B
	public byte B
	{
		get => (byte) GetValue(BProperty);
		set => SetValue(BProperty, value);
	}

	public static readonly DependencyProperty BProperty =
		DependencyProperty.Register
		(
			nameof(B),
			typeof(byte),
			typeof(ColorPickerUC),
			new FrameworkPropertyMetadata((byte) 0, SliderValueChanged)
		);
	#endregion

	#region A
	public byte A
	{
		get => (byte) GetValue(AProperty);
		set => SetValue(AProperty, value);
	}

	public static readonly DependencyProperty AProperty =
		DependencyProperty.Register
		(
			nameof(A),
			typeof(byte),
			typeof(ColorPickerUC),
			new PropertyMetadata((byte) 255, SliderValueChanged)
		);
	#endregion

	public static void SliderValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		//Wenn ein Slider sich ändert, muss der Wert von allen 4 Slidern genommen werden, und bei PickedColor geschrieben werden
		//d: Objekt, von dem die Methode aufgerufen wurde (hier ColorPickerUC)
		byte a = (byte) d.GetValue(AProperty);
		byte r = (byte) d.GetValue(RProperty);
		byte g = (byte) d.GetValue(GProperty);
		byte b = (byte) d.GetValue(BProperty);

		Color c = Color.FromArgb(a, r, g, b);
		d.SetValue(PickedColorProperty, c);
	}

	public static void PickedColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		Color c = (Color) d.GetValue(PickedColorProperty);

		byte a = c.A;
		byte r = c.R;
		byte g = c.G;
		byte b = c.B;

		d.SetValue(AProperty, a);
		d.SetValue(RProperty, r);
		d.SetValue(GProperty, g);
		d.SetValue(BProperty, b);
	}
}