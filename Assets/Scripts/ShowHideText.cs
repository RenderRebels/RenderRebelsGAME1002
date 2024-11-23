using TMPro;
using UnityEngine;

public class ShowHideText : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; 
    private bool isTextVisible = false;  

    void Start()
    {
  
        textMeshPro.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
         
            isTextVisible = !isTextVisible;

          
            textMeshPro.gameObject.SetActive(isTextVisible);
        }
    }
}