using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area1BoolScript : MonoBehaviour
{
    //public LevelTriggerKitchen levelTriggerKitchen;

    public bool HasObject1;
    public bool HasObject2;
    public bool HasObject3;


    public GameObject Object1InHand;
    public GameObject Object2InHand;
    public GameObject Object3InHand;

    //public PlacedDownObject placedDownObject;

    void Start()
    {
        HasObject1 = false;
        HasObject2 = false;
        HasObject3 = true;

        gameObject.tag = "Barrier";
    }
    
    
    
    private void Update()
    {

        if (HasObject1)
        {
            Object1InHand.SetActive(true);

        }
        else if (!HasObject1)
        {
            Object1InHand.SetActive(false);
        }

        if (HasObject2)
        {
            Object2InHand.SetActive(true);

        }
        else if (!HasObject2)
        {
            Object2InHand.SetActive(false);
        }

        if (HasObject3)
        {
                Object3InHand.SetActive(true);
                
        }
        else if (!HasObject3)
        {
            Object3InHand.SetActive(false);
        }

    }
}
