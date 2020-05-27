using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;

    public bool dialogueactive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueactive && Input.GetKeyUp(KeyCode.E))
        {
            dBox.SetActive(false);
            dialogueactive = false;
        }
    }
    public void ShowBox(string dialogue)
    {
        dialogueactive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }
   
}
