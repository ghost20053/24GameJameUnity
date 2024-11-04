using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;

    void Start()
    {

    }


    void Awake()
    {
       // Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        //(collision.gameObject);
        Destroy(gameObject);
    }
}
