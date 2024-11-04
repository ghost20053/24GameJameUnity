using UnityEngine;
using System.Collections;

public class ColorChangeItems : MonoBehaviour 
{
	private int r;
	private int g;
	private int b;

	// An alternate set of numbers with a different behaviour
	//private float redF;
	//private float greenF;
	//private float blueF;

	private Renderer rend;

	void Start()
	{
		rend = GetComponent<Renderer>();
	}

	void OnMouseEnter()
	{
        // Ideally there should be a range limit on this interaction to prevent it activating from long distances. 
        // Use distance check between player and this object. 
        //
        // Reticle also should have a range indicator to suggest the interaction is possible but inactive. 
        // Try getting UI image components for out of range / in range, and activate / deactivate them accordingly.

        r = Random.Range(0, 2);
		g = Random.Range(0, 2);
		b = Random.Range(0, 2);

		// Alternate numbers 
		//redF = Random.Range(0.3f, 1.0f);
		//greenF = Random.Range(0.3f, 1.0f);
		//blueF = Random.Range(0.3f, 1.0f);

		// REFINEMENT CHALLENGE - this interaction appears to not work if the random color is the same as the white default colour. How to fix this?
	}
	

	void OnMouseOver()
	{
		Debug.Log(r + " " + g + " " + b);
		rend.material.color -= new Color(r, g, b) * Time.deltaTime;

		//Debug.Log(redF + " " + greenF + " " + blueF);
		//rend.material.color -= new Color(redF, greenF, blueF) * Time.deltaTime;
	}


	void OnMouseExit()
	{
		rend.material.color = Color.white;
	}
}
