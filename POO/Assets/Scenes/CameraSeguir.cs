using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguir : MonoBehaviour
{
    public Transform _alvo;
    public float interpolacao = 12f;
    public float CamMoveSpeed = 5f;
    public float distancia = -5;
    
    void Start()
    {
        
    }
    void Update()
    {
        transform.position = Vector3.Lerp(
            transform.position, 
            new Vector3(_alvo.position.x,transform.position.y,_alvo.position.z+distancia), 
            CamMoveSpeed * Time.deltaTime);
         
    }
}