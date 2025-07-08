using System.Windows.Markup;

namespace M008;

public class EnumExtension : MarkupExtension
{
	/// <summary>
	/// Dieser Typ kann im XAML beschrieben werden (ähnlich wie bei einem Binding)
	/// </summary>
	public Type EnumType { get; set; }

	/// <summary>
	/// Der Rückgabewert dieser Methode wird in der GUI eingefüllt
	/// </summary>
	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (EnumType == null)
			throw new ArgumentNullException(nameof(EnumType));

		if (!EnumType.IsEnum)
			throw new ArgumentException("EnumType ist kein gültiger Enum Typ");

		return Enum.GetValues(EnumType);
	}
}
