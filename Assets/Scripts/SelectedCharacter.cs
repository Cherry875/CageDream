using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedCharacter : MonoBehaviour
{
    public SpriteRenderer icon;
    public Sprite[] spriteArray;
    public Dropdown dropdown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        icon.sprite=spriteArray[dropdown.value];
    }
}
