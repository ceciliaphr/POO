using UnityEngine;

public class _Carro
{
    private string nome;
    private int numero_de_rodas;
    private string cor;
    private float preco;

    public string getNome()
    {
        return this.nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }
    
    public string getCor()
    {
        return this.cor;
    }

    public void setCor(string cor)
    {
        this.cor = cor;
    }
    
}