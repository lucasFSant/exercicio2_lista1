double[] salarios = new double[5];
string? j;
for (int i = 0; i < salarios.Length; i++)
{
    Console.Write((i + 1) + "º salário:");
    j = Console.ReadLine();
    Double.TryParse(j, out salarios[i]);
    if (salarios[i] < 1000)
    {
        salarios[i] = salarios[i] * 1.1;
    }
}
Console.WriteLine();
for (int n = 0; n < salarios.Length; n++)
{
    Console.WriteLine((n + 1) + "º salário: R$" + salarios[n].ToString("0.00"));
}