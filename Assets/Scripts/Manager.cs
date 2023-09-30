using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI ClicksTotalText;

    public float TotalClicks;

    public static Manager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void AddClicks()
    {
        TotalClicks++;

        if(FindObjectOfType<BonusClicksUpgrade>() != null)
        {
            FindObjectOfType<BonusClicksUpgrade>().Clicked();
        }

        //Make sure to update the text last thing!
        ClicksTotalText.text = TotalClicks.ToString("0");
    }

}