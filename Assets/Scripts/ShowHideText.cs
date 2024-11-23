using System.Collections;
using TMPro;
using UnityEngine;

public class ShowHideText : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    private bool isTextVisible = false;
    private float timer = 5f; // Timer duration in seconds
    private bool timerRunning = false; // Flag to track if the timer is running

    void Start()
    {
        textMeshPro.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Toggle visibility of the text
            isTextVisible = !isTextVisible;
            textMeshPro.gameObject.SetActive(isTextVisible);

            // Start the timer if the text is shown
            if (isTextVisible && !timerRunning)
            {
                StartCoroutine(HideTextAfterTime());
            }
        }
    }

    private IEnumerator HideTextAfterTime()
    {
        timerRunning = true; // Set flag to true to indicate timer is running
        yield return new WaitForSeconds(timer); // Wait for the specified time
        textMeshPro.gameObject.SetActive(false); // Hide the text
        isTextVisible = false; // Update the visibility state
        timerRunning = false; // Reset the timer running flag
    }
}