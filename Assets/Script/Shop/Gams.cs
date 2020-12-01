using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gams : MonoBehaviour
{
    public TMP_Text textGams; 
    public TMP_Text textCoins;
    public Color32 active_Color;
    public Color32 deactive_Color;
    public GameObject unable;
    public GameObject disable;
    public void Start()
    {
        textGams.color=active_Color; 
    }
    public void ChangeColor()
    {
        textGams.color=active_Color;
        textCoins.color=deactive_Color;
        unable.SetActive(true);
        disable.SetActive(false);
    }
    
}



