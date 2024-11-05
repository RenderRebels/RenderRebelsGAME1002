using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class NPCInteraction : MonoBehaviour
{
     public DialogueRunner runner;
    public GameObject speechPrompt;
    public string startNode;
    public bool canStartConversation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        runner = FindAnyObjectByType<DialogueRunner>();
        speechPrompt.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space))
        {
            if (!runner.IsDialogueRunning && canStartConversation)
            {
                runner.StartDialogue(startNode);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerTrigger player = collision.GetComponent<PlayerTrigger>();
        if (player != null) // it is a player
        {
            canStartConversation = true;
            speechPrompt.SetActive(canStartConversation);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerTrigger player = collision.GetComponent<PlayerTrigger>();
        if (player != null) // it is a player
        {
            canStartConversation = false;
            speechPrompt.SetActive(canStartConversation);

            runner.Stop();
        }
    }
}
