using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Handles all the mines to be bought
public class BuyMine : MonoBehaviour
{
    public Text textBox;
    public int gravelMineCost;

    public void BuyGravelMine()
    {
        if (GlobalClicks.currencyCount >= gravelMineCost)
        {
            GlobalClicks.currencyCount -= 10;
        }
        else
        {
            StartCoroutine(FadeTextToZeroAlpha(2f, textBox));
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
