using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MachinaController : MonoBehaviour {

    public InputField machinaValue;

    private Animation anim;
    private bool stillMoving;
    private int retrieved;


    private static bool machinaExists;

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animation>();
        

        if (!machinaExists)
        {
            machinaExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update() {
        /*
        retrieved = string.IsNullOrEmpty(machinaValue.text) ? 0 : int.Parse(machinaValue.text);// int.TryParse(machinaValue.text);
        int temp = retrieved;
        Debug.Log("The retrieved is " + retrieved);

        stillMoving = false;
        if (retrieved != 0)
        {
            stillMoving = true;
            anim.SetBool("stillMoving", stillMoving);
            retrieved--;
        }
        else {
            stillMoving = false;
        }
        */

    }

    
    public void GetInput(string value) {
        
        int retrieved = int.Parse(value);
        Debug.Log("The retrieved is " + retrieved);

        stillMoving = false;
        int temp = retrieved;

        for (int count = 1; count <= temp; count++)
        {
            anim.PlayQueued("Machina");
            if (GameObject.Find("Player").GetComponent<PlayerHealthManager>().playerCurrentHealth <= 60)
            {
                GameObject.Find("Player").GetComponent<PlayerHealthManager>().HealPlayer(5);
            }
        }

        /*
        for (int i=0;i<temp;i++)
        {
            stillMoving = true;
            anim.SetBool("stillMoving", stillMoving);
            temp--;
        }
        if (temp == 0) {
            stillMoving = false;
        }
            Debug.Log("The temp is " + temp);

    */

    }

    
}
