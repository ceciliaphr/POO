using UnityEngine;

public class Carro
{
    private string nome;
    private string cor;
    private int numero_de_rodas;
    private float preco;

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string NomeDoCarro()
    {
        return this.nome;
    }
   
   
    public void AtribuirCor(string cor)
    {
        this.cor = cor;
    }

    public string CorDoCarro()
    {
        return this.cor;
    }

    public void AtribuirNumero_de_rodas(int numero_de_rodas)
    {
        this.numero_de_rodas = numero_de_rodas;
    }

    public int Numero_de_rodas()
    {
        return this.numero_de_rodas;
    }
   
    public void AtribuirPreco(float preco)
    {
        this.preco = preco;
    }

    public float Preco()
    {
        return this.preco;
    }

    public bool ComparePreco( Carro carro )
    {
        if (this.preco > carro.Preco())
        {
            return true;
        }
        return false;
    }


}