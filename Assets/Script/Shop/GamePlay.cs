using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public TMP_Text text_Currency;
    public TMP_Text text_GamePlay;
    public TMP_Text text_Deals;
    public Color32 active_Color;
    public Color32 deactive_Color;
    public GameObject unable;
    public GameObject disable;
    public GameObject disableTwo;
    public void ChangeColor()
    {
        text_Currency.color=deactive_Color;
        text_GamePlay.color=active_Color;
        text_Deals.color=deactive_Color;
        unable.SetActive(true);
        disable.SetActive(false);
        disableTwo.SetActive(false);
    }
}
