using Ucu.Poo.RoleplayGame;

SpellsBook book = new SpellsBook();
book.Spells.Add(new Spell("Spell1", 22, 11));

Wizard gandalf = new Wizard("Gandalf");
gandalf.Staff = new Staff("Gandalf", 1, 5);
gandalf.SpellsBook = book;

Dwarf gimli = new Dwarf("Gimli");
gimli.Axe = new Axe("Axe", 33);
gimli.Helmet = new Helmet("Helmet", 42);
gimli.Shield = new Shield("Shield", 26);

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

gimli.ReceiveAttack(gandalf.AttackValue);

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

gimli.Cure();

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

