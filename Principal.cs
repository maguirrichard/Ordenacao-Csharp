using System;

class Program
{
    static void Main(string[] args)
    {
        int n = (args.Length < 1) ? 1000 : int.Parse(args[0]);
		DateTime inicio;
		DateTime fim;

        Geracao algoritmo;

        //Inicializacao do algoritmo de ordenacao
        algoritmo = new Bolha(n);
        //algoritmo = new Countingsort(n);
        //algoritmo = new Heapsort(n);
        //algoritmo = new Insercao(n);
        //algoritmo = new Mergesort(n);
        //algoritmo = new Quicksort(n);
        //algoritmo = new Selecao(n);
        //algoritmo = new Shellsort(n);

        //Geracao do conjunto a ser ordenado
		algoritmo.aleatorio();
		//algoritmo.crescente();
		//algoritmo.decrescente();

        //Mostrar o conjunto a ser ordenado
		algoritmo.mostrar();

        inicio = algoritmo.now();
        algoritmo.sort();
        fim = algoritmo.now();
        TimeSpan diff = fim - inicio;

        //Mostrar o conjunto ordenado, tempo de execucao e status da ordenacao
		algoritmo.mostrar();
        Console.WriteLine("Tempo para ordenar: " + diff);
        Console.WriteLine("isOrdenado: " + algoritmo.isOrdenado());
    }
}

