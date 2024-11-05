using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class npcInteraction : MonoBehaviour
{
    public DialogueRunner runner;
    public GameObject speechPrompt;
    public string startnode;
    // Start is called before the first frame update
    void Start()
    {
        speechPrompt.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerTrigger player = collision.GetComponent<PlayerTrigger>();
        if (player != null)
        {
            speechPrompt.SetActive(true);
            runner.StartDialogue("Mort");
        }
    }
       private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerTrigger player = collision.GetComponent<PlayerTrigger>();
        if (player != null)
        {
            speechPrompt.SetActive(false);
        }
    }
}


