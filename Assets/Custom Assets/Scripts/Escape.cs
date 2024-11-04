using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(sceneName:"EscapeEnding");
    }
}