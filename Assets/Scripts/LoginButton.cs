using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginButton : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject message;

    // Start is called before the first frame update
    void Start()
    {
        DeleteMessage();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //ボタンがクリックされた時
    public void OnClick()
    {
        Debug.Log("クリックされた！");
        if(dropdown.value != 0)
        {
            GoTomMain();
        }
        else
        {
            Debug.Log("まだ役職が選ばれていません");
            message.SetActive(true);
            //3sec後にメッセージを消す
            Invoke(nameof(DeleteMessage), 2.0f);
        }
    }

    private void DeleteMessage()
    {
        message.SetActive(false);
    }

    void GoTomMain()
    {
        SceneManager.LoadScene("MainScene");
    }
}
