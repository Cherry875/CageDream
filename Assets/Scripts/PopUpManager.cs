using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpManager : MonoBehaviour
{
    public PopUpPanel popUpPanelPrefab;
    PopUpPanel popUpPanel;
    public GameObject canvas;

    static PopUpPanel instance;
 
    // インスタンスを取得
    public static PopUpPanel GetInstance()
    {
        return instance;
    }

    public void showPopUp(string text){
        popUpPanel = Instantiate(popUpPanelPrefab.gameObject).GetComponent<PopUpPanel>();
        popUpPanel.transform.SetParent (canvas.transform, false);
        popUpPanel.SetText(text); // テキストを入れる
    }
}
