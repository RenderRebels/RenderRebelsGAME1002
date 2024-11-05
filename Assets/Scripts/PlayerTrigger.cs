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
    titleText.text = area.title;
    byLineText.text = "By: " + area.author;

 }

}
