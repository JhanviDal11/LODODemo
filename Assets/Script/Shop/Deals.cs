using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Deals : MonoBehaviour
{
    public TMP_Text text_Currency;
    public TMP_Text text_GamePlay;
    public TMP_Text text_Deals;
    public Color32 active_Color;
    public Color32 deactive_Color;
    public GameObject unable;
    public GameObject disableOne;
    public GameObject disableTwo;
    public void ChangeColor()
    {
        text_Currency.color=deactive_Color;
        text_GamePlay.color=deactive_Color;
        text_Deals.color=active_Color;
        unable.SetActive(true);
        disableOne.SetActive(false);
        disableTwo.SetActive(false);
    }
}
