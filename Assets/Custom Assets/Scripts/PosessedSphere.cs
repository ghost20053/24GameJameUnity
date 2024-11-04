using UnityEngine;
using System.Collections;

public class PosessedSphere : MonoBehaviour 
{

	public Transform[] locations;
    // variables for ensuring the critter position is random among the non-current positions in the array.
    private int curLocationIndex;
    private int testLocationIndex;
    private bool validPos = false;

	public GameObject critter;

    private Material cubeMaterial; // private variable to get the renderer of this object - allows us to get its material.
    private Color defaultColor = Color.yellow;
    private Color HoverColor = Color.cyan;
    private Color ClickColor = Color.red;

    void Start()
    {
        curLocationIndex = Random.Range(0, locations.Length);// set an initial location index.

        
        cubeMaterial = this.GetComponent<Renderer>().material; // First get the material from the Renderer Component.
        cubeMaterial.color = defaultColor; // set the color to the default yellow.
    }
    private void OnMouseEnter()
	{
        // Ideally there should be a range limit on this interaction to prevent it activating from long distances. 
        // Use distance check between player and this object. 
        //
        // Reticle also should have a range indicator to suggest the interaction is possible but inactive. 
        // Try getting UI image components for out of range / in range, and activate / deactivate them accordingly.
        cubeMaterial.color = HoverColor;
	}

	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(0)) // Was the left (0) mouse button pressed. Use (1) for right, etc
		{
            StartCoroutine("ColourFade");  // Feedback refinement: add a coroutine lerping the colour from a click colour (white?) back to green.

            validPos = false; // the critter is moving, so we need to find a new valid location.
            while (!validPos) // if we have not found a valid position
            {
                testLocationIndex = Random.Range(0, locations.Length); // find a random position in the array
                if (testLocationIndex != curLocationIndex) // if it is not the same position as the current location, it is valid, so we can proceed
                {
                    curLocationIndex = testLocationIndex; // update the current location index
                    MoveCritter();
                }
            }
		}
	}

	void OnMouseExit()
	{
        cubeMaterial.color = defaultColor;
    }

    IEnumerator ColourFade()
    {
        for (float t = 0.0f; t<1; t+= 0.05f) // the value of 't' is the fade time
        {
            cubeMaterial.color = Color.Lerp(ClickColor, HoverColor, t);         // Lerp the current material colour towards the default colour by 't' as a ratio (i.e. t = 0 is full ClickColor, t = 1 is full HoverColor).
            yield return null;
        }


    }

    private void MoveCritter()
    {
        critter.transform.position = locations[curLocationIndex].position; // move the critter to the initial position.
        validPos = true; // Set the position as valid.
    }
}
