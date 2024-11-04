using UnityEngine;
using System.Collections;

public class TrickyDoor : MonoBehaviour 
{
	public GameObject door; // public gameObject variable for the door. Set this from the inspector.
    private Material cubeMaterial; // private variable to get the renderer of this object - allows us to get its material.

    void Start()
    {
        cubeMaterial = this.GetComponent<Renderer>().material; // First get the material from the Renderer Component.
        cubeMaterial.color = Color.yellow;
    }

    // did the player just mouse onto this game object?
    void OnMouseEnter()
	{
        // Ideally there should be a range limit on this interaction to prevent it activating from long distances. 
        // Use distance check between player and this object. 
        //
        // Reticle also should have a range indicator to suggest the interaction is possible but inactive. 
        // Try getting UI image components for out of range / in range, and activate / deactivate them accordingly.

        // Change colour to show feedback for mouse on.
        cubeMaterial.color = Color.green;
        // SETUP: play a sound.

        // set the door gameObject to false, making it vanish
        door.SetActive(false); 
	}

	// did the player just mouse off this game object?
	void OnMouseExit()
	{
        // Change colour to show feedback for mouse off.
        cubeMaterial.color = Color.yellow;
        door.SetActive(true); // set the door gameObject to true again to make it appear

        // REFINEMENT CHALLENGE - The door disappears and reappears very abruptly on Mouse Enter / Exit,
        // and up close this can result in ugly hysterisis between on/off states by accident. How to smooth this out?
	}
}
