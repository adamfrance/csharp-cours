using static System.Convert; // pour utiliser ToInt32

int a = 10;
double b = a;
WriteLine($"a is {a}, b is {b}");

double c = 9.7;
int d = (int)c;
WriteLine($"c is {c}, d is {d}");

double[,] doubles = {
  { 9.49, 9.5, 9.51 },
  { 10.49, 10.5, 10.51 },
  { 11.49, 11.5, 11.51 },
  { 12.49, 12.5, 12.51 } ,
  { -12.49, -12.5, -12.51 },
  { -11.49, -11.5, -11.51 },
  { -10.49, -10.5, -10.51 },
  { -9.49, -9.5, -9.51 }
};

foreach (double n in doubles)
{
    WriteLine(format:
      "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
      arg0: n,
      arg1: Math.Round(value: n, digits: 0,
              mode: MidpointRounding.AwayFromZero));
}


int number = 12;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString())

// méthode Try : si méthode Truc, il existe TryTruc qui renvoie un bool
int number = int.Parse("123");
bool success = int.TryParse("123", out int number);
bool success = Uri.TryCreate("https://localhost:5000/api/customers",UriKind.Absolute, out Uri serviceUrl);

