int year = 2023;
float since = 4.2F;
double age = 21.9;
decimal semester = 9.05M;
String carrer = "System Engineer";
String name = "Omar Parra";
String ty = "thanks!!!";
bool verification = true;
char pin = '*';
Decimal structDecimal = 99.999M;


Console.WriteLine("Hello, World!");

Console.WriteLine("I'm " + name + ", today is {0} and i'm {1} years old, i'm studing {2} at the University Popular of Cesar " +
"i stay in {3} semester but i'm learnig to programation since {4} semester", year, age, carrer,semester, since);

Console.WriteLine("All this information about me is: \n" + verification + structDecimal + "%");

Console.WriteLine(pin + ty + pin);


Console.ReadLine();