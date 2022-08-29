using static System.Console;
int N = InputNumber("Введите число: ");
if (N != 0)
{
    int n = N < 0 ? Math.Abs(N)
 + 2 : N;
    int[] arrey = new int[n];
    arrey = GetCub(N, n);
    WriteArrey("Кубы от 1 до "+Convert.ToString(N)+": ", arrey, n);
}
else { WriteLine(N)
; }

void WriteArrey(string text, int[] arrey, int n)
{
    Write(text);
    Write(arrey[0]);
    for (int i = 1; i < n; i++)
    {
        Write($", {arrey[i]}");
    }
}

int InputNumber(string text)
{
    bool isNumber = false; int x = 0;
    while (!isNumber)
    {
        Write(text);
        isNumber = int.TryParse(ReadLine(), out x);
        if (!isNumber) { WriteLine("Это не число"); }
    }
    return x;
}

int[] GetCub(int N, int n)
{
    int[] arrey = new int[n];
    for (int i = 1; i < n + 1; i++)
    {
        arrey[i - 1] = N < 0 ? (int)Math.Pow(2 - i, 3) : i * i * i;
    }
    return arrey;
}