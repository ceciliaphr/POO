using System;
using UnityEngine;

public class TesteDeDano : MonoBehaviour
{
    private Personagem personagem;
    
    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("Ataque"))
        {
            int energia_atual = personagem.Energia() 
                                - colisao.gameObject.GetComponent<Ataque>().AtaqueDoInimigo();
           
            personagem.AtribuirEnergia(energia_atual);
           
            Debug.Log("O personagem " +personagem.Nome()+" tem agora "+personagem.Energia());
        }
    }

    void Start()
    {
        personagem = GetComponent<Personagem>();
    }

  
    void Update()
    {
        
    }
}