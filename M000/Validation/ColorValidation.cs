using System.Globalization;
using System.Windows.Controls;
using System.Windows.Media;

namespace M000.Validation;

internal class ColorValidation : ValidationRule
{
	private readonly Color Empty = Color.FromArgb(0, 0, 0, 0);

	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		//if (value is Color c && c == Empty)
		//	return new ValidationResult(false, "Wähle eine Farbe aus.");
		//return ValidationResult.ValidResult;

		Color color = (Color) value;

		if (color == Empty)
		{
			return new ValidationResult(false, "Wähle eine Farbe aus.");
		}

		return ValidationResult.ValidResult;
	}
}
