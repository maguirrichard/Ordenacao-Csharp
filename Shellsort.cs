using System;

public class Shellsort: Geracao
{
	/**
	* Construtor.
	* @param int tamanho do array de numeros inteiros.
	*/
	public Shellsort(int tamanho)
	{

    }

	/**
	* Algoritmo de ordenacao Shellsort.
	*/
	public override void sort()
	{
		var h = 1;
		do {
			h = (h * 3) + 1;
		}while (h < this.n);

		do {
			h /= 3;
			for (var cor = 0; cor < h; cor++)
			{
				this.insercaoPorCor(cor, h);
			}
		}while (h != 1);		
	}

    /**
	* Metodo que efetua a insercao nos pseudo-arrays do Shellsort.
	* @param int cor cor do pseudo array.
	* @param int h passo do shelsort
	*/
	public void insercaoPorCor(int cor, int h)
	{
		for (var i = (h + cor); i < this.n; i += h)
		{
			var tmp = this.array[i];
			var j = i - h;
			while ((j >= 0) && (this.array[j] > tmp))
			{
				this.array[j + h] = this.array[j];
				j -= h;
			}
			this.array[j + h] = tmp;
		}
	}
}