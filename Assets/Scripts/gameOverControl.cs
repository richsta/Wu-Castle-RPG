using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameOverControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
