using System;

public class Quicksort: Geracao
{
	/**
	* Construtor.
	* @param int tamanho do array de numeros inteiros.
	*/
	public Quicksort(int tamanho)
	{

    }

	/**
	* Algoritmo de ordenacao Quicksort.
	*/
	public override void sort()
	{
		this.quicksort(0, this.n - 1);		
	}

    /**
	* Algoritmo de ordenacao Quicksort.
	* @param int esq inicio do array a ser ordenado
	* @param int dir fim do array a ser ordenado
	*/
	private void quicksort(int esq, int dir)
	{
		var i = esq;
		var j = dir;
		var pivo = this.array[(int)((dir + esq) / 2)];

		while (i <= j)
		{
			while (this.array[i] < pivo) i++;
			while (this.array[j] > pivo) j--;

			if (i <= j)
			{
				this.swap(i, j);
				i++;
				j--;
			}
		}
		if (esq < j)
		{
			this.quicksort(esq, j);
		}
        
		if (i < dir)
		{
			this.quicksort(i, dir);
		}
	}
}