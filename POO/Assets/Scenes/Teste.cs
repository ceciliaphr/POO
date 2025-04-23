using UnityEngine;
public class Teste : MonoBehaviour
{ 
    Carro fusca = new Carro();
    Carro gol = new Carro();
    
    Caminhao caminhao = new Caminhao();
    
    void Start()
    {
        fusca.AtribuirNome("Fusca de Pai");
        fusca.AtribuirCor("Amarelo");
        fusca.AtribuirNumero_de_rodas(4);
        fusca.AtribuirPreco(2050.90f);
        Debug.Log("O "+ fusca.NomeDoCarro() +" é "+ fusca.CorDoCarro() + " tem " + fusca.Numero_de_rodas()+
                  " e custa R$"+fusca.Preco());
        
        gol.AtribuirNome("Gol do Falstão");
        gol.AtribuirCor("Verde");
        gol.AtribuirNumero_de_rodas(4);
        gol.AtribuirPreco(3000.00f);
        Debug.Log("O "+ gol.NomeDoCarro());

        if (fusca.ComparePreco(gol))
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o carro " + gol.NomeDoCarro());
        }
        else
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais barato do que o carro " + gol.NomeDoCarro());
        }

        caminhao.AtribuirTipoDeCarroceria("Larga");
        caminhao.AtribuirNumero_de_rodas(8);
        caminhao.AtribuirPreco(6000.00f);
        caminhao.AtribuirCor("Azul");
        caminhao.AtribuirNome("Caminhão do Falstão");
        
        //fusca.AtribuirTipoDeCarroceria("Larga");

        if (fusca.ComparePreco(caminhao))
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o " + caminhao.NomeDoCarro());
        }
        else
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais barato do que o " + caminhao.NomeDoCarro());
        }

        
        
        
    }
    void Update()
    {
        
    }
}