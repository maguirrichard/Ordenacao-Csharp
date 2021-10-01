using System;

public class Mergesort: Geracao
{
	/**
	* Construtor.
	* @param int tamanho do array de numeros inteiros.
	*/
	public Mergesort(int tamanho)
	{

    }

	/**
	* Algoritmo de ordenacao Mergesort.
	*/
	public override void sort()
	{
		this.mergesort(0, this.n - 1);
	}

    /**
	* Algoritmo de ordenacao Mergesort.
	* @param int esq inicio do array a ser ordenado
	* @param int dir fim do array a ser ordenado
	*/
	private void mergesort(int esq, int dir)
	{
		if (esq < dir)
		{
			var meio = (int)((esq + dir) / 2);
			this.mergesort(esq, meio);
			this.mergesort(meio + 1, dir);
			this.intercalar(esq, meio, dir);
		}
	}

    /**
		* Algoritmo que intercala os elementos entre as posicoes esq e dir
		* @param int esq inicio do array a ser ordenado
		* @param int meio posicao do meio do array a ser ordenado
		* @param int dir fim do array a ser ordenado
		*/
	public void intercalar(int esq, int meio, int dir)
	{
		int n1;
		int n2;
		int i;
		int j;
		int k;

		//Definir tamanho dos dois subarrays
		n1 = meio - esq + 1;
		n2 = dir - meio;
		int[] a1 = new int[n1 + 1];
		int[] a2 = new int[n2 + 1];

		//Inicializar primeiro subarray
		for (i = 0; i < n1; i++)
		{
			a1[i] = this.array[esq + i];
		}

		//Inicializar segundo subarray
		for (j = 0; j < n2; j++)
		{
			a2[j] = this.array[meio + j + 1];
		}

		//Sentinela no final dos dois arrays
		a1[i] = a2[j] = 2147483647;

		//Intercalacao propriamente dita
		for (i = j = 0, k = esq; k <= dir; k++)
		{
			this.array[k] = (a1[i] <= a2[j]) ? a1[i++] : a2[j++];
		}
	}
}