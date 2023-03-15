//№14 с.83
int N = 10;
char[] setchars1 =new char[N];
char[] setchars2 = new char[N];

CreateSet(N, setchars1);
CreateSet(N, setchars2);

PrintSet(setchars1);
PrintSet(setchars2);
var rezult = setchars1.Intersect(setchars2);
PrintSet1(rezult);

static void CreateSet(int N, char[] setchars1)
{
    Console.WriteLine("Ввод с клавиатуры");
    for (int i = 0; i < N; i++)
        setchars1[i] = Convert.ToChar(Console.ReadLine());
}

static void PrintSet(char[] setchars1)
{
    Console.WriteLine("Печать множества");
    foreach (char c in setchars1)
        Console.WriteLine(c);
}
static void PrintSet1(IEnumerable<char> setchars1)
{
    Console.WriteLine("Печать множества");
    foreach (char c in setchars1)
        Console.WriteLine(c);
}