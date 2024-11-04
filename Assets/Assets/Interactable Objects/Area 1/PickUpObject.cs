using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpObject : MonoBehaviour
{
    public GameObject Barrier;

    private void Start()
    {
        Barrier.SetActive(true);
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.gameObject.SetActive(false);

            Barrier.SetActive(false);

            
        }
    }

}
