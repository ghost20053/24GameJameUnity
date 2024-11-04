using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;


    void Start()
    {
        gameObject.tag = "Destructable";
    }


    void Awake()
    {
       Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);

        if(other.gameObject.CompareTag("Destructable"))
        {
            Destroy(other.gameObject);
        }
    }
}
