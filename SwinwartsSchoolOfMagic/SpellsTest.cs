using System;
using NUnit.Framework;

namespace SwinwartsSchoolOfMagic
{
	[TestFixture()]
	public class SpellsTest
	{
		[Test()]
		public void TestTeleport()
		{
			Spell s = new Spell("Test Teleport", SpellKind.Teleport);
			StringAssert.AreEqualIgnoringCase("Poof... you appear somewhere else", s.Cast());
		}

		[Test()]
		public void TestInvisibility()
		{
			Spell s = new Spell("Test Invisibility", SpellKind.Invisibility);
			StringAssert.AreEqualIgnoringCase("Zippp... where am I?", s.Cast());
		}

		[Test()]
		public void TestHeal()
		{
			Spell s = new Spell("Test Invisibility", SpellKind.Heal);
			StringAssert.AreEqualIgnoringCase("Ahhh... you feel better", s.Cast());
		}

		[Test()]
		public void TestChangeName()
		{
			Spell s = new Spell("Test Change Name", SpellKind.Heal);
			s.Name = "New Name";

			StringAssert.AreEqualIgnoringCase("New Name", s.Name);
		}
	}
}
