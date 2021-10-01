using System;

public class Geracao
{
    protected int[] array;
    protected int n;

    /**
	* Construtor.
	*/
    public Geracao()
    {
        this.array = new int[100];
        this.n = this.array.Length;
    }

    /**
	* Construtor.
	* @param int tamanho do array de numeros inteiros.
	*/
    public Geracao(int tamanho)
    {
        this.array = new int[tamanho];
        this.n = this.array.Length;
    }

    /**
	* Produz um array ordenado de modo crescente.
	*/
    public void crescente()
    {
        for (var i = 0; i < this.n; i++)
        {
            this.array[i] = i;
        }
    }

    /**
	* Produz um array ordenado de modo decrescente.
	*/
    public void decrescente()
    {
        for (var i = 0; i < this.n; i++)
        {
            this.array[i] = this.n - 1 - i;
        }
    }

    /**
	* Troca o conteudo de duas posicoes do array
	* @param i int primeira posicao
	* @param j int segunda posicao
	*/
    public void swap(int i, int j)
    {
        var temp = this.array[i];
        this.array[i] = this.array[j];
        this.array[j] = temp;
    }

    /**
	* Produz um array com numeros aleatorios.
	*/
    public void aleatorio()
    {
        Random rand = new Random();
        this.crescente();
        for (var i = 0; i < this.n; i++)
        {
            this.swap(i, Math.Abs(rand.Next()) % this.n);
        }
    }

    /**
	* Recebe um Efetua a leitura dos elementos via entrada padrao.
	*/
    public void entrada(int[] vet)
    {
        this.n = vet.Length;
        this.array = new int[this.n];
        for (var i = 0; i < this.n; i++)
        {
            this.array[i] = vet[i];
        }
    }

    /**
	* Efetua a leitura dos elementos via entrada padrao.
	*/
	public void entradaPadrao()
	{
		n = Convert.ToInt32(Console.ReadLine());
		this.array = new int[n];
		for (var i = 0; i < n; i++)
		{
			this.array[i] = Convert.ToInt32(Console.ReadLine());
		}
	}

    /**
	* Mostra os k primeiros elementos do array.
	* @param int k indica a quantidade de elementos do array a serem mostrados.
	*/
	public void mostrar(int k)
	{
		Console.Write("[");
		for (var i = 0; i < k; i++)
		{
			Console.Write(" (" + i.ToString() + ")" + this.array[i].ToString());
		}
		Console.WriteLine("]");
	}

    /**
	* Mostra os elementos do array.
	*/
	public void mostrar()
	{
		Console.Write("[");
		for (var i = 0; i < this.n; i++)
		{
			Console.Write(" (" + i.ToString() + ")" + this.array[i].ToString());
		}
		Console.WriteLine("]");
	}

    /**
	* Retorna o timestamp atual
	* @return timestamp atual
	*/
	public DateTime now()
	{
		return DateTime.Now;
	}

    /**
	* Retorna verdadeiro/falso indicando se o array esta ordenado
	* @return boolean indicando se o array esta ordenado
	*/
	public bool isOrdenado()
	{
		bool resp = true;
		for (var i = 1; i < this.n; i++)
		{
			if (this.array[i] < this.array[i - 1])
			{
				i = this.n;
				resp = false;
			}
		}
		return resp;
	}

    /*
	* Metodo a ser implementado nas subclasses
	*/
	public virtual void sort()
	{
		Console.WriteLine("Metodo a ser implementado nas subclasses.");
	}
}
