using UnityEngine;
using System.Collections;

public class NPCDialogue : MonoBehaviour
{

    public GameObject crossAnim;
    public GameObject treeAnim;
    public GameObject tree;

    public bool treeActive;

    public string[] answerButtons;
    public string[] Questions;
    bool DisplayDialog = false;
    bool ActivateQuest = false;

    private Animation anim;

    private Animation animCross;

    // Use this for initialization
    void Start()
    {

        anim = treeAnim.GetComponent<Animation>();
        animCross = crossAnim.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        GUI.backgroundColor = Color.yellow;
        //GUI.skin = talkSkin;
        GUILayout.BeginArea(new Rect((Screen.width / 2) - 200, (Screen.height / 2), 300, 300));
        if (DisplayDialog && !ActivateQuest)
        {

            GUILayout.Label(Questions[0]);
            GUILayout.Label(Questions[1]);
            GUILayout.Label(Questions[2]);
            if (GUILayout.Button(answerButtons[0]))
            {

                GameObject.Find("Player").GetComponent<PlayerHealthManager>().HealPlayer(20);
                anim.Play("Tree_Aligned");

                treeActive = true;
                tree.SetActive(true);

                ActivateQuest = true;
                //HasDoneQuest = false;
                DisplayDialog = false;
            }

            if (GUILayout.Button(answerButtons[1]))
            {

                animCross.Play("Wrong_cross");

                treeActive = false;
                tree.SetActive(false);

                GameObject.Find("Player").GetComponent<PlayerHealthManager>().HurtPlayer(10);
                //HasDoneQuest = false;
                DisplayDialog = false;
            }

            if (GUILayout.Button(answerButtons[2]))
            {

                animCross.Play("Wrong_cross");

                treeActive = false;
                tree.SetActive(false);
                GameObject.Find("Player").GetComponent<PlayerHealthManager>().HurtPlayer(10);
                DisplayDialog = false;
            }
        }

        if (DisplayDialog && ActivateQuest) // && HasDoneQuest)
        {
            GUILayout.Label(Questions[3]);
            if (GUILayout.Button(answerButtons[3]))
            {
                //QuestCompleted();
                DisplayDialog = false;

            }
            if (GUILayout.Button(answerButtons[4]))
            {
                //QuestCompleted();
                ActivateQuest  = false;

            }
        }

        GUILayout.EndArea();
        /*
        if (ActivateQuest == true)
        {
            GUI.DrawTexture(new Rect(10, 10, 200, 150), texture1);
        }
        */
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                DisplayDialog = true;
            }
        }
    }

    void OnTriggerExit2D()
    {
        DisplayDialog = false;

    }
    
}