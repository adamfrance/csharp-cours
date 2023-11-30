using Library.Shared;
ConfigureConsole();

#region Instancier une classe Person

Person bob = new();
WriteLine(bob);
bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
  year: 1965, month: 12, day: 22,
  hour: 16, minute: 28, second: 0,
  offset: TimeSpan.FromHours(-5));
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.ColossusOfRhodes;
WriteLine("{0} aime {1}. Son index est {2}", // Long date.
  arg0: bob.Name, 
  arg1: bob.FavoriteAncientWonder,
  arg2: (int)bob.FavoriteAncientWonder);

// fonctionne avec toutes les versions de C#
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);

// fonctionne avec C#3 et plus
bob.Children.Add(new Person { Name = "Johanna" });

// fonctionne avec C# 9 et plus
bob.Children.Add(new() { Name = "Zoe" });
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}

#endregion

#region Instancier une classe Person avec une syntaxe plus courte
Person alice = new()
{
    Name = "Alice jackAccount",
    Born = new(1998, 3, 7, 16, 28, 0,
    // This is an optional offset from UTC time zone.
    TimeSpan.Zero)
};
WriteLine(format: "{0} was born on {1:d}.", // Short date.
  arg0: alice.Name, arg1: alice.Born);
#endregion

#region instanciation de deux instances de BankAccount

BankAccount.BankOverdraft = 100M;
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mr. Jones";
jonesAccount.Balance = 2500;
WriteLine(format: "{0} a sur son compte {1:C} et a droit à {2:C} de découvert",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance,
    arg2: BankAccount.BankOverdraft
);

BankAccount.BankOverdraft = 100M;
BankAccount jackAccount = new();
jackAccount.AccountName = "Mr. Jack";
jackAccount.Balance = 1300;
WriteLine(format: "{0} a sur son compte {1:C} et a droit à {2:C} de découvert",
    arg0: jackAccount.AccountName,
    arg1: jackAccount.Balance,
    arg2: BankAccount.BankOverdraft
);

#endregion

// champ constant de la classe Person
WriteLine($"{bob.Name} est un {Person.Species}");

