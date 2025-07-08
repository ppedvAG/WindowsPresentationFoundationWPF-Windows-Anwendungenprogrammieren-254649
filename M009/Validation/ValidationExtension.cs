using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace M009.Validation;

public class ValidationExtension : MarkupExtension
{
	/// <summary>
	/// Das Binding ins Backend ({Binding Path=...})
	/// </summary>
	public Binding Binding { get; set; }

	/// <summary>
	/// Einzelne Regel
	/// </summary>
	public ValidationRule Rule { get; set; }

	/// <summary>
	/// Mehrere Regeln
	/// </summary>
	public ValidationRuleCollection RuleCollection { get; set; }

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (Rule != null)
			Binding.ValidationRules.Add(Rule);

		if (RuleCollection != null)
			foreach (ValidationRule r in RuleCollection)
				Binding.ValidationRules.Add(r);

		return Binding.ProvideValue(serviceProvider); //Mach weiter mit dem Binding
	}
}

public class ValidationRuleCollection : Collection<ValidationRule>;