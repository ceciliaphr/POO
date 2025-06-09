using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Animator animator;
    private Player movimentoPlayer;
    public float velocidadeDaAnimacao = 1;
    
    void Start()
    {
        movimentoPlayer = GetComponent<Player>();
    }
    void Update()
    {
        animator.SetBool("Andando", movimentoPlayer.Andando);
        animator.speed = velocidadeDaAnimacao;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Ataque");  
        }
    }
}