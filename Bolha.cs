using System;

public class Bolha: Geracao
{
	/**
	* Construtor.
	* @param int tamanho do array de numeros inteiros.
	*/
	public Bolha(int tamanho)
	{

    }

	/**
	* Algoritmo de ordenacao Bolha.
	*/
	public override void sort()
	{
		for (var i = (this.n - 1); i > 0; i--)
		{
			for (var j = 0; j < i; j++)
			{
				if (this.array[j] > this.array[j + 1])
				{
					this.swap(j, j + 1);
				}
			}
		}
	}
}