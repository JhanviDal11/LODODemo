using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Global : MonoBehaviour
{
    public TMP_Text textFriend; 
    public TMP_Text textGlobal;
    public Color32 active_Color;
    public Color32 deactive_Color;
    public GameObject unable;
    public GameObject disable;
    public void Start()
    {
        textGlobal.color=active_Color; 
    }
    public void ChangeColor()
    {
        textFriend.color=deactive_Color;
        textGlobal.color=active_Color;
        unable.SetActive(true);
        disable.SetActive(false);
    }
}
