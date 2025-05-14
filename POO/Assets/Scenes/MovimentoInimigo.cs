using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private GameObject _player;
    
    private Rigidbody _rigidbody;
    private float velocidade;

    public float raioDeVisao = 10;
    private bool naVisao = false;

    private SphereCollider _sphereCollider;


    void Start()
    {
        
        _rigidbody =  gameObject.GetComponent<Rigidbody>();
        velocidade = gameObject.GetComponent<Inimigo>().Velocidade();
        _sphereCollider = gameObject.GetComponent<SphereCollider>();

        _player = GameObject.FindWithTag("Player");

    }

    void Update()
    {
        _sphereCollider.radius = raioDeVisao;

        //if (Vector3.Distance(trasform.position, player.transform.position) < raioDeVisao
        if (naVisao == true)
        {
            transform.LookAt(_player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position,
                _player.transform.position,
                velocidade * Time.deltaTime);
        }
    }

    void OnTriggerStay(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = true;
        }
    }


    void OnTriggerExit(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = false;
        }
    }


}