using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHealth;
    public int playerCurrentHealth;

	// Use this for initialization
	void Start () {
        playerCurrentHealth = 20;


    }
	
	// Update is called once per frame
	void Update () {
        if (playerCurrentHealth <= 0)
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene("gameover");
        }

        if (playerCurrentHealth >= 100)
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene("win");
        }
    }

    public void HurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;
    }
    public void HealPlayer(int healthToGive)
    {
        playerCurrentHealth += healthToGive;
    }
    public void setMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
}
