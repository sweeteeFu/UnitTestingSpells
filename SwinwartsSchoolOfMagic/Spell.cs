using System;
namespace SwinwartsSchoolOfMagic
{
	/// <summary>
	/// Spell can be cast in order to have an affect
	/// on their surroundings. There are a number of
	/// different kinds of spells, each with their own
	/// affects.
	/// </summary>
	public class Spell
	{
		private string _name;
		private SpellKind _kind;

		/// <summary>
		/// Gets or sets the name of the spell.
		/// </summary>
		/// <value>Name of the spell</value>
		public string Name
		{ 
			get { return name; }
			set { _name = value; }
		}

		/// <summary>
		/// Only gets the kind of spell.
		/// </summary>
		/// <value>Kind of the spell</value>
		public SpellKind Kind
		{
			get { return _kind; }
		}

		/// <summary>
		/// Initializes a new instance of the
		/// <see cref="T:SwinwartsSchoolOfMagic.Spell"/> class.
		/// Includes name and kind of the spell.
		/// </summary>
		/// <param name="name">Name of the spell</param>
		/// <param name="kind">Kind of the spell (Teleport, Invisibility or Heal)</param>
		public Spell(string name, SpellKind kind)
		{
			_name = name;
			_kind = kind;
		}

		/// <summary>
		/// Cast this spells, causing it to have an
		/// effect on its surroundings.
		/// </summary>
		/// <returns>Result/Effect of the spell</returns>
		public string Cast()
		{
			//message for each spell
			string result = " ";
			if (_kind == SpellKind.Teleport)
			{
				result = "Poof... you appear somewhere else";
			}
			else if (_kind == SpellKind.Heal)
			{
				result = "Ahhh... you feel better";
			}
			else if (_kind == SpellKind.Invisibility)
			{
				result = "Zippp... where am I?";
			}
			return result;
		}
	}
}
