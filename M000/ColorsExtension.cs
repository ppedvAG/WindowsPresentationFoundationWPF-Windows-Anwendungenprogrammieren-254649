using System.Windows.Markup;
using System.Windows.Media;

namespace M000;

public class ColorsExtension : MarkupExtension
{
	public NamedColor[] Colors { get; set; }

	public ColorsExtension()
	{
		//PropertyInfo[] prop = typeof(Colors).GetProperties();
		//Colors = new NamedColor[prop.Length];
		//for (int i = 0; i < prop.Length; i++)
		//{
		//	Colors[i] = new NamedColor((Color) prop[i].GetValue(null)!, prop[i].Name);
		//}

		Colors = typeof(Colors)
			.GetProperties()
			.Select(prop => new NamedColor((Color) prop.GetValue(null)!, prop.Name))
			.ToArray();
	}

	public override object ProvideValue(IServiceProvider serviceProvider) => Colors;
}

public class NamedColor
{
	public Color Color { get; set; }

	public SolidColorBrush Brush => new SolidColorBrush(Color);

	public string Name { get; set; }

	public string ColorCode { get; set; }

	public NamedColor(Color color, string name)
	{
		Color = color;
		Name = name;
		ColorCode = Color.ToString();
	}
}