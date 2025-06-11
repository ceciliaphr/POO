using UnityEngine;

public class TesteCodigo : MonoBehaviour
{
    public void Mensagem(string mensagem)
    {
        Debug.Log(mensagem);
        return;
    }

    public void IdadeDaPessoa(string nome, int idade)
    {
        //Debug.Log("A pessoa de nome "+nome+" tem "+idade+" anos.");

        string frase = "A pessoa de nome " + nome + " tem " + idade + " anos.";
        
        Mensagem(frase);
    }

    void Start()
    {
        IdadeDaPessoa("João", 15);
        IdadeDaPessoa("Maria",43);
        IdadeDaPessoa("Jose",43);
        IdadeDaPessoa("Marcia",48);
    }
    
    void Update()
    {
        
    }
}