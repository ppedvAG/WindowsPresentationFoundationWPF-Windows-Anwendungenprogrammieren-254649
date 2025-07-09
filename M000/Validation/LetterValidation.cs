using System.Globalization;
using System.Windows.Controls;

namespace M000.Validation;

public class LetterValidation : ValidationRule
{
	/// <summary>
	/// Diese Methode wird vor dem Binding durchgeführt
	/// value ist der Wert, welcher ans Backend/Frontend gesendet wird
	/// </summary>
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string str = value as string;

		if (str == null || str.All(char.IsLetter))
			return ValidationResult.ValidResult;

		return new ValidationResult(false, "Die Eingabe darf nur aus Buchstaben bestehen!");
	}
}
