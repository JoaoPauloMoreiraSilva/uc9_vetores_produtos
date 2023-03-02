string[] vet_prod = new string[3];
string[] vet_prodtipo = new string[3];
double[] vet_prodvalor = new double[3];

int i = 0;

for (i = 0; i <= 2; i++)
{
    Console.WriteLine("Informe a descriçao do" + (i + 1) + "produto");
    vet_prod[i] = Console.ReadLine();

    Console.WriteLine("Informe o tipo do" + (i + 1) + "produto");
    vet_prodtipo[i] = Console.ReadLine();

    Console.WriteLine("Informe o valor do" + (i + 1) + "produto");
    vet_prodvalor[i] = double.Parse(Console.ReadLine());

    Console.Clear();
}

for (i = 0; i <= 2; i++)
{
    Console.WriteLine("Descriçao: " + vet_prod[i] + " --- tipo: " + vet_prodtipo[i] + " -- Valor: " + vet_prodvalor[i]);
}

