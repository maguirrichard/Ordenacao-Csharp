using System;

public class Selecao: Geracao
{
	/**
	* Construtor.
	* @param int tamanho do array de numeros inteiros.
	*/
	public Selecao(int tamanho)
	{

    }

	/**
	* Algoritmo de ordenacao Selecao.
	*/
	public override void sort()
	{
		for (var i = 0; i < (this.n - 1); i++)
		{
			var menor = i;
			for (var j = (i + 1); j < this.n; j++)
			{
				if (this.array[menor] > this.array[j])
				{
					menor = j;
				}
			}
			this.swap(menor, i);
		}		
	}
}