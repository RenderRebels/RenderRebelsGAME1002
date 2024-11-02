using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractabke : MonoBehaviour
{
    public GameObject Intertact;
    void Start()
    {
        Intertact.SetActive(false);
    }
   
    private void OnTriggerEnter(Collider other)
    {
       PlayerTrigger playerTrigger = other.GetComponent<PlayerTrigger>();
        if (playerTrigger != null)
        {
            Intertact.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerTrigger playerTrigger = other.GetComponent<PlayerTrigger>();
        if (playerTrigger != null)
        {
            Intertact.SetActive(false);
        }
    }
}
