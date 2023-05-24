int[] Z = new int[4];
Random rnd = new Random();

Console.Write("Массив: ");

for (int i = 0; i < Z.Length; i++)
{
    Z[i] = rnd.Next(-10, 10);
    Console.Write(Z[i] + " ");
}

Console.WriteLine();

int S = Z.Where(x => x % 2 == 0 && x < 3).Sum();
int P = Z.Where(x => x % 2 != 0 && x > 1).Sum();
int R = P + S;
Console.WriteLine("S = " + S);
Console.WriteLine("P = " + P);
Console.WriteLine("R = " + R);