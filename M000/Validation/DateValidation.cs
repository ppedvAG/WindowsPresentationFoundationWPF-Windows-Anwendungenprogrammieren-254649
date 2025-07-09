using System.Globalization;
using System.Windows.Controls;

namespace M000.Validation;

public class DateValidation : ValidationRule
{
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		DateTime dt = (DateTime) value;

		if (dt.Year < 1900)
			return new ValidationResult(false, "Datum darf nicht vor 1900 liegen!");

		if (dt > DateTime.Now)
			return new ValidationResult(false, "Datum darf nicht in der Zukunft liegen!");

		return ValidationResult.ValidResult;
	}
}
