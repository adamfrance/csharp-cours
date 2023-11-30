// TimesTable(1, 5);

ConfigureConsole(culture: "fr-FR");
decimal taxToPay = CalculateTax(amount: 150, twoLetterRegionCode: "FR");
WriteLine($"Vous essayez de ne pas payer {taxToPay:C}");
