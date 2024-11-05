using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcInteraction : MonoBehaviour
{
    public GameObject speechPrompt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerTrigger player = collision.GetComponent<PlayerTrigger>();
        if (player != null)
        {
            speechPrompt.SetActive(true);
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


