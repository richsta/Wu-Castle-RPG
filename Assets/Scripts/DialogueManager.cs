using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public Text dText;
    public GameObject dInput;

    public bool dialogueActive;
    public bool inputActive;

    public string[] dialogueLines;
    public int currentLine;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (dialogueActive && Input.GetKeyUp(KeyCode.Space)) {
            //dBox.SetActive(false);
            //dialogueActive = false;

            currentLine++;


        }

        //Input field
        if (currentLine == dialogueLines.Length-1)
        {
            dInput.SetActive(true);
            inputActive = true;
        }

        if (currentLine >= dialogueLines.Length) {
            dBox.SetActive(false);
            dialogueActive = false;
            dInput.SetActive(false);
            inputActive = false;
            currentLine = 0;
        }

        dText.text = dialogueLines[currentLine];

    }

    public void ShowBox(string dialogue) {
        dialogueActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }

    public void ShowDialogue()
    {
        dialogueActive = true;
        dBox.SetActive(true);
    }
}
