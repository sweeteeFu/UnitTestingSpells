using System;

namespace SwinwartsSchoolOfMagic
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Spell[] mySpells = new Spell[5];

			mySpells[0] = new Spell("Mitch's mighty mover", SpellKind.Teleport);
			mySpells[1] = new Spell("Paul's potent poultice", SpellKind.Heal);
			mySpells[2] = new Spell("David's dashing disappearance", SpellKind.Invisibility);
			mySpells[3] = new Spell("Stan's stunning shifter", SpellKind.Teleport);
			mySpells[4] = new Spell("Lachlan's lavish longevity", SpellKind.Heal);

			CastAll(mySpells);

			Console.ReadLine();
		}

		public static void CastAll(Spell[] spells)
		{
			foreach (Spell s in spells)
			{
				Console.WriteLine("{0}! {1}", s.Name, s.Cast());
			}
		}
	}
}
