using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Emotes : MonoBehaviour
{
    public TMP_Text text_Dice;
    public TMP_Text text_Pins;
    public TMP_Text text_Bubble;
    public TMP_Text text_Theme;
    public TMP_Text text_Emotes;
    public Color32 active_Color;
    public Color32 deactive_Color;
   
    public void ChangeColor()
    {
        text_Dice.color=deactive_Color;
        text_Pins.color=deactive_Color;
        text_Bubble.color=deactive_Color;
        text_Theme.color=deactive_Color;
        text_Emotes.color=active_Color;
        
    }
}
