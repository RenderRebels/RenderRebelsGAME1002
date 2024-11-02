using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class NPCInteractabke : MonoBehaviour
{
    
    public GameObject Intertact;
    public DialogueRunner runner;
    public string startNode;
    public bool canStartConversation;
    void Start()
    {
        runner =FindAnyObjectByType<DialogueRunner>();
        Intertact.SetActive(false);

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

    private void OnTriggerEnter(Collider other)
    {
       PlayerTrigger playerTrigger = other.GetComponent<PlayerTrigger>();
        if (playerTrigger != null)
        {
            canStartConversation = true;
            Intertact.SetActive(true);

            //if (!runner.IsDialogueRunning)
            //{
               // runner.StartDialogue(startNode);
            //}
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerTrigger playerTrigger = other.GetComponent<PlayerTrigger>();
        if (playerTrigger != null)
        {
            canStartConversation= false;
            Intertact.SetActive(false);
            runner.Stop();
        }
    }
}
