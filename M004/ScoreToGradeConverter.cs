using System.Globalization;
using System.Windows.Data;

namespace M004;

public class ScoreToGradeConverter : IValueConverter
{
	/// <summary>
	/// Quelle -> Ziel
	/// double -> string
	/// </summary>
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		int score = (int) (double) value;
		switch (score)
		{
			case >= 90:	return "Sehr Gut";
			case >= 80:	return "Gut";
			case >= 70:	return "Befriedigend";
			case >= 60:	return "Genügend";
			case >= 50:	return "Mangelhaft";
			default: return "Ungenügend";
		}
	}

	/// <summary>
	/// Ziel -> Quelle
	/// </summary>
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => 0d;
}
