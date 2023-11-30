partial class Program
{
  private static void DeferredExecution(string[] names)
  {
    SectionTitle("Deferred execution");
    // question: quels sont les noms qui finissent par m?

    // avec une méthode d'extension LINQ
    var query1 = names.Where(name => name.EndsWith("m"));

    // avec une syntaxe de compréhension LINQ
    var query2 = from name in names where name.EndsWith("m") select name;

    // Rendre le résultat des requêtes en tableau
    string[] result1 = query1.ToArray();
    List<string> result2 = query2.ToList();

    foreach (string name in query1)
    {
      WriteLine(name);
      names[2] = "Jimmy";
    }
  }

  private static void FilteringUsingWhere(string[] names)
  {
    SectionTitle("Filtering entities using Where");
    var query = names.Where(name => name.Length > 4).OrderBy(name => name.Length).ThenBy(name => name);
    foreach (string item in query)
    {
      WriteLine(item);
    }
  }

  static bool NameLongerThanFour(string name)
  {
    return name.Length > 4;
  }

}
