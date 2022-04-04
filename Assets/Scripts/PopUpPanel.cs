using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class PopUpPanel : MonoBehaviour
{
 
    public void SetText(string text)
    {
        Text t = transform.GetChild(0).GetComponent<Text>();
        t.text = text;
    }

    void Start()
    {
        Destroy(gameObject, 2);
    }
 
}