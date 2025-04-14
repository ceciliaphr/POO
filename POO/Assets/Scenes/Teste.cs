using UnityEngine;

public class Teste : MonoBehaviour
{
    Carro fusca = new Carro(); 
    Carro gol = new Carro();
    
    //Caminhao caminhao = new caminhao();
    
    //Start is called once before the first execution of Update after the MonoBehaviour is created
    

    void Start()
    {
        fusca.AtribuirNome("Fusca de Father");
        Debug.Log("0 " + fusca.NomeDoCarro());
        
    }

    void Update()
    {

    }
}

 