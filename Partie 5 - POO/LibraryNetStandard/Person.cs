namespace Library.Shared;

// public est un modificateur d'accès: accessible de l'extérieur de 
// cette library
// si pas public: uniquement dispo dans cette assembly
// par défaut: c'est internal
// private signifie accessible depuis le parent
public class Person(string initialName, string homePlace)
// instanciation classe: Person joe = new(initialName: "Joe", homePlace: "Tataouine")
{
    #region Fields: Data or state for this person.
    Name = initialName;
    HomePlace = homePlace;
    public DateTimeOffset Born;

    public WondersOfTheAncientWorld FavoriteAncientWonder;

    public List<Person> Children = new()

    public const string Species = "Homo Intelligus"; // récupéré avec le nom de la classe

    #endregion
}




