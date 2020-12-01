using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Currency : MonoBehaviour
{
   
   public TMP_Text text_Currency;
   public TMP_Text text_GamePlay;
   public TMP_Text text_Deals;
   public Color32 active_Color;
   public Color32 deactive_Color;
   public GameObject unable;
   public GameObject disable;
   public GameObject disableTwo;
   public void Start()
   {
      text_Currency.color=active_Color; 
   }
   public void ChangeColor()
   {
      text_Currency.color=active_Color;
      text_GamePlay.color=deactive_Color;
      text_Deals.color=deactive_Color;
      unable.SetActive(true);
      disable.SetActive(false);
      disableTwo.SetActive(false);
   }
}
