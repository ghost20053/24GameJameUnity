using UnityEngine;
using System.Collections;

public class ShyCube : MonoBehaviour 
{
	public Transform player;

	public Transform cube;

	public float max;

	// Use this for initialization
	void Start () 
	{
		if (player == null)
			GameObject.Find("FPSController");
		max = GetComponent<SphereCollider>().radius;
	}

	void OnTriggerStay()
	{
		if (player)
		{
			float d = Vector3.Distance(player.position, transform.position);
			print("Distance to player: " + d);
			float scale = d / max;
			cube.localScale = new Vector3(scale, scale, scale);
		}
	}
}
