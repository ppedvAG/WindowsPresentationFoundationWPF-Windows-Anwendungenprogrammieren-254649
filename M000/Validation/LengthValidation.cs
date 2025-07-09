using System.Globalization;
using System.Windows.Controls;

namespace M000.Validation;

public class LengthValidation : ValidationRule
{
	public int Min { get; set; }

	public int Max { get; set; }

	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string str = value as string;

		if (str == null)
			return new ValidationResult(false, "Gib einen Namen ein.");

		if (str.Length < Min || str.Length > Max)
			return new ValidationResult(false, $"Name muss zw. {Min} und {Max} Zeichen haben!");

		return ValidationResult.ValidResult;
	}
}
