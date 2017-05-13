using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIControl : MonoBehaviour {

    public Slider slider;

    void Awake()
    {
        if (slider)
        {
            //GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("curVol");
            //slider.value = GetComponent<AudioSource>().volume;
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changeScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void VolumeControl(float volumeControl)
    {
       // GetComponent<AudioSource>().volume = volumeControl;
       // PlayerPrefs.SetFloat("curVol", GetComponent<AudioSource>().volume);
    }
}
