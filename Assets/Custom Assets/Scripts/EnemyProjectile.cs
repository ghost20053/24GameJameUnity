using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class EnemyProjectile : MonoBehaviour
{

    void Awake()
    {
       Destroy(gameObject);
    }

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);

        if(other.gameObject.CompareTag("Player"))
        {
            Health -= 10;
        }
    }

    static float Health;
    static float MaxHealth = 100;

    public Slider HealthBar;

    private void Start()
    {
        HealthBar.minValue = 0;
        HealthBar.maxValue = MaxHealth;
        Health = MaxHealth;
    }

    private void Update()
    {
        HealthBar.value = Health;
        Damage();
    }
}
