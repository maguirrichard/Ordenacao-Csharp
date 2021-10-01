using System;

public class Insercao: Geracao
{
	/**
	* Construtor.
	* @param int tamanho do array de numeros inteiros.
	*/
	public Insercao(int tamanho)
	{

    }

	/**
	* Algoritmo de ordenacao Inserção.
	*/
	public override void sort()
	{
		for (var i = 1; i < this.n; i++)
		{
			var tmp = this.array[i];
			var j = i - 1;
			while ((j >= 0) && (this.array[j] > tmp))
			{
				this.array[j + 1] = this.array[j];
				j--;
			}
			this.array[j + 1] = tmp;
		}		
	}
}