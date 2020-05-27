using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour
{
    public string dialogue;
    private DialogueManager dMng;
    // Start is called before the first frame update
    void Start()
    {
        dMng = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
       if(other.gameObject.name == "Player")
        { 
            if (Input.GetKeyDown(KeyCode.E))
            {
                dMng.ShowBox(dialogue);
            }
        }
            
        
    }
}
