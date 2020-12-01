using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueBarCoroutines : MonoBehaviour
{
    public RectTransform Header;
    public RectTransform Event;
    public RectTransform Chat;
    public RectTransform ShopAndSocial;
    public RectTransform RankAndSetting;
    public List<GameObject> objs;
    
    public void OnEnable()
    {
        StartCoroutine(BlueBarCoroutine());
        StartCoroutine(EventCoroutine());
        StartCoroutine(ChatCoroutine());
        StartCoroutine(ShopAndSocialCoroutine());
        StartCoroutine(RankAndSettingCoroutine());
        StartCoroutine(ButtonCoroutine(objs));
    }

    IEnumerator BlueBarCoroutine()
    {
        Header.anchoredPosition=new Vector2(0,205);
        while (Header.anchoredPosition.y>1)
        {
            yield return new WaitForSeconds(0.0001f);
            Header.anchoredPosition = new Vector2(0, Header.anchoredPosition.y-1);
        }
    }
    IEnumerator EventCoroutine()
    {
        Event.anchoredPosition=new Vector2(-226,Event.anchoredPosition.y);
        while(Event.anchoredPosition.x<1)
        {
            yield return new WaitForSeconds(0.0001f);
            Event.anchoredPosition = new Vector2(Event.anchoredPosition.x+1, Event.anchoredPosition.y);
        }
    }
    IEnumerator ChatCoroutine()
    {
        Chat.anchoredPosition=new Vector2(100,Chat.anchoredPosition.y);
        while(Chat.anchoredPosition.x>-65)
        {
            yield return new WaitForSeconds(0.0001f);
            Chat.anchoredPosition = new Vector2(Chat.anchoredPosition.x-1, Chat.anchoredPosition.y);
        }
    }
    IEnumerator ShopAndSocialCoroutine()
    {  
       // print("Hello");
       ShopAndSocial.anchoredPosition=new Vector2(-226,ShopAndSocial.anchoredPosition.y);
        while(ShopAndSocial.anchoredPosition.x<1)
        {
            yield return new WaitForSeconds(0.0001f);
            ShopAndSocial.anchoredPosition = new Vector2(ShopAndSocial.anchoredPosition.x+1, ShopAndSocial.anchoredPosition.y);
        }
    }
    IEnumerator RankAndSettingCoroutine()
    {
        RankAndSetting.anchoredPosition=new Vector2(100,RankAndSetting.anchoredPosition.y);
        while(RankAndSetting.anchoredPosition.x>-165)
        {
            yield return new WaitForSeconds(0.0001f);
            RankAndSetting.anchoredPosition = new Vector2(RankAndSetting.anchoredPosition.x-1, RankAndSetting.anchoredPosition.y);
        }
    }
    IEnumerator ButtonCoroutine(List<GameObject> obj)
    {
        
        StartCoroutine(ScaleCoroutine(obj[0]));
        yield return new WaitForSeconds(0.05f);
        StartCoroutine(ScaleCoroutine(obj[1]));
        yield return new WaitForSeconds(0.05f);
        StartCoroutine(ScaleCoroutine(obj[2]));
        yield return new WaitForSeconds(0.05f);
        StartCoroutine(ScaleCoroutine(obj[3]));
        yield return new WaitForSeconds(0.05f);
        StartCoroutine(ScaleCoroutine(obj[4]));
        yield return new WaitForSeconds(0.05f);
    }

    IEnumerator ScaleCoroutine(GameObject obj)
    {
        while (obj.transform.localScale.x < 0.4f && obj.transform.localScale.y < 0.5f)
        {
            obj.transform.localScale = new Vector2(0.4f, 0.5f);
            yield return new WaitForSeconds(0.2f);
        }
        obj.transform.localScale = new Vector2(0.3942261f, 0.3942261f);
    }
}
