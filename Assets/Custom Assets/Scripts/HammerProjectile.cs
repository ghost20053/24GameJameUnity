using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    public GameObject Enemy;


    void Start()
    {

    }


    void Awake()
    {
       Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
           Destroy(gameObject);

        //HealthBar(TakeDamage);
    }
}
