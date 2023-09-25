string[] array = new string[5];
array[0] = "Omar";
array[1] = "Steven";
array[2] = "Lizbeth";
array[3] = "Course";
array[4] = "C#";

string[] name = { "Omar", "Steven", "Lizbeth", "Course", "C#"};

int[] age = new int[5];

age[0] = 5;
age[1] = 10;
age[2] = 21;
age[3] = 38;
age[4] = 99;

int[] ages = {8,90,21,10,5};

//Arrays bidimensionales
double[,] result = new double[2, 2] { { 9, 4.6 }, { 6.9, 7.10 } };

//Arrays tridimensional       //filas, columnas, datos
double[,,] doubles = new double[2, 2, 3] { { { 9, 4.6, 27.9 }, { 6.9, 7.10, 9} }, { { 42, 41.56, 5}, { 68.9, 27.16, 9 } }, };

Console.WriteLine("Nombre: {0} "+ " " + name[3] + "\nAge: " + ages[2] + "\nNota: {1}", array[0] , doubles[1, 0, 2]);


Console.ReadLine();