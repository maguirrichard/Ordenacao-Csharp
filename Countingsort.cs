using System;

public class Countingsort: Geracao
{
	/**
	* Construtor.
	* @param int tamanho do array de numeros inteiros.
	*/
	public Countingsort(int tamanho)
	{

    }

	/**
	* Algoritmo de ordenacao Countingsort.
	*/
	public override void sort()
	{
		//Array para contar o numero de ocorrencias de cada elemento
		int[] count = new int[this.getMaior() + 1];
		int[] ordenado = new int[this.n];
		//Inicializar cada posicao do array de contagem 
		for (var i = 0; i < count.Length; count[i] = 0, i++);
		
		//Agora, o count[i] contem o numero de elemento iguais a i
		for (var i = 0; i < this.n; count[this.array[i]]++, i++);
		
		//Agora, o count[i] contem o numero de elemento menores ou iguais a i
		for (var i = 1; i < count.Length; count[i] += count[i - 1], i++);
		
		//Ordenando
		for (var i = this.n - 1; i >= 0;
                ordenado[count[this.array[i]] - 1] = this.array[i], count[this.array[i]]--, i--);
		
		//Copiando para o array original
		for (var i = 0; i < this.n; this.array[i] = ordenado[i], i++);
	}

    /**
	* Retorna o maior elemento do array.
	* @return maior elemento
	*/
	public int getMaior()
	{
		var maior = this.array[0];
		for (var i = 0; i < this.n; i++)
		{
			if (maior < this.array[i])
			{
				maior = this.array[i];
			}
		}
		return maior;
	}
}