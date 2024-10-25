using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTrigger : MonoBehaviour
{
    // Start is called before the first frame update
public TMPro.TextMeshProUGUI titleText;
    public TMPro.TextMeshProUGUI byLineText;


   public void OnTriggerEnter2D(Collider2D collision)
    {
        AreaTrigger area = collision.GetComponent<AreaTrigger>();

        StopAllCoroutines();
        StartCoroutine(AnimateTitle(area, 5));
    }
     public IEnumerator AnimateTitle(AreaTrigger area, float duration)
    {
        titleText.text = area.title;
        byLineText.text = "By: " + area.author;

        float timeElapsed = 0;
        while(timeElapsed < duration)
        {
            float percentage = timeElapsed / duration;
            titleText.alpha = 1.0f - percentage;
            byLineText.alpha = 1.0f - percentage;
            yield return new WaitForEndOfFrame();
            timeElapsed += Time.deltaTime;
        }

        titleText.text = "";
        byLineText.text = "";
    }
}
