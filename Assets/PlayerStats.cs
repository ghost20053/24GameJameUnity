using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
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
        DamageOnHit();
    }


    void DamageOnHit()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Health -= 10;
        }
    }
}
