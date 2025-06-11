using UnityEngine;

public class TesteDanoInimigo : MonoBehaviour
{
    private Inimigo inimigo;
    
    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("AtaqueHeroi"))
        {
            int energia_atual = inimigo.Energia() 
                                - colisao.gameObject.GetComponent<AtaquePlayer>().AtaqueDoPersonagem();
           
            inimigo.AtribuirEnergia(energia_atual);
           
            Debug.Log("O personagem " +inimigo.Nome()+" tem agora "+inimigo.Energia());
        }
    }

    void Start()
    {
        inimigo = GetComponent<Inimigo>();
    }

  
    void Update()
    {
        
    }
}