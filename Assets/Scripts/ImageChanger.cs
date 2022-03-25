using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    //Dropdownを格納する変数
    public Dropdown dropdown;
    //イメージと結びつける
    public GameObject doctor;
    public GameObject kazoku;
    public GameObject student;
    public GameObject painter;
    public GameObject military;
    public GameObject business;
    public GameObject conductor;
    public GameObject maid;
    public GameObject crew;

    public void Start()
    {
        HideCharaImage(); 
    }

    private void HideCharaImage()
    {
       doctor.SetActive(false);
       kazoku.SetActive(false); 
       student.SetActive(false); 
       painter.SetActive(false); 
       maid.SetActive(false);
       military.SetActive(false); 
       crew.SetActive(false); 
       conductor.SetActive(false); 
       business.SetActive(false);     
    }

    // オプションが変更されたときに実行するメソッド
    public void ChangeImage()
    {
        Debug.Log("valueは"+dropdown.value);
        //選択前は「選択してください」表示、イラストなし
        if (dropdown.value == 0)
        {
            HideCharaImage(); 
        }
        //選択後は立ち絵が表示される
        if (dropdown.value == 1)
        {
            Debug.Log("医者だ！");
            HideCharaImage(); 
            doctor.SetActive(true);
        }
        else if (dropdown.value == 2)
        {
            Debug.Log("華族だ！");
            HideCharaImage(); 
            kazoku.SetActive(true);
        }
        else if (dropdown.value == 3)
        {
            Debug.Log("画家だ！");
            HideCharaImage(); 
            painter.SetActive(true);
        }
        else if (dropdown.value == 4)
        {
            Debug.Log("学生だ！");
            HideCharaImage(); 
            student.SetActive(true);
        }
        else if (dropdown.value == 5)
        {
            Debug.Log("軍人だ！");
            HideCharaImage(); 
            military.SetActive(true);
        }
        else if (dropdown.value == 6)
        {
            Debug.Log("実業家だ！");
            HideCharaImage(); 
            business.SetActive(true);
        }
        else if (dropdown.value == 7)
        {
            Debug.Log("車掌だ！");
            HideCharaImage(); 
            conductor.SetActive(true);
        }
        else if (dropdown.value == 8)
        {
            Debug.Log("メイドだ！");
            HideCharaImage(); 
            maid.SetActive(true);
        }
        else if (dropdown.value == 9)
        {
            Debug.Log("メイドだ！");
            HideCharaImage(); 
            crew.SetActive(true);
        }
    }
}