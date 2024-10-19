namespace ApredendoHashSet;

internal class Program
{
    static void Main()
    {
        //HashSet é uma lista de valores unicos
        HashSet<int> qualquerCoisa = new HashSet<int>();
        // adcionando itens
        qualquerCoisa.Add(1);
        qualquerCoisa.Add(2);
        qualquerCoisa.Add(1); // valor repetido

        Console.WriteLine(qualquerCoisa.Count);
        // o valor repetido não será contado como um item adcionado, pois esse valor já existe!
    }
}