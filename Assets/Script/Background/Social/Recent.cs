using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SocialRecent : MonoBehaviour
{
    public TMP_Text text_FBFriend;
    public TMP_Text text_GameFriend;
    public TMP_Text text_UnreadMessage;
    public TMP_Text text_Recent;
    public Color32 active_Color;
    public Color32 deactive_Color;
    public GameObject unable;
    public GameObject disableOne;
    public GameObject disableTwo;
    public GameObject disableThree;
    public void ChangeColor()
    {
        text_FBFriend.color=deactive_Color;
        text_GameFriend.color=deactive_Color;
        text_UnreadMessage.color=deactive_Color;
        text_Recent.color=active_Color;
        unable.SetActive(true);
        disableOne.SetActive(false);
        disableTwo.SetActive(false);
        disableThree.SetActive(false);
    }
}
