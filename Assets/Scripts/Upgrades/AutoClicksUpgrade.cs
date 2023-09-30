using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AutoClicksUpgrade : MonoBehaviour
{
    public int autoClicksPerSecond;
    public int minimumClicksToUnlockUpgrade;

    private Manager manager;

    public TextMeshProUGUI priceText, amountText;

    private void Start()
    {
        manager = Manager.instance;
        UpdateText();
    }
    public void BuyUpgrade()
    {
        if (manager.TotalClicks >= minimumClicksToUnlockUpgrade)
        {
            manager.TotalClicks -= minimumClicksToUnlockUpgrade;

            autoClicksPerSecond++; //Here, set the amount of clicks that automatically gets added every second if you buy the upgrade again
            minimumClicksToUnlockUpgrade *= 2; //Here, set the amount of clicks needed to buy the upgrade again

            UpdateText();
        }
    }

    private void Update()
    {
        if (autoClicksPerSecond > 0)
        {
            manager.TotalClicks += autoClicksPerSecond * Time.deltaTime;

            manager.ClicksTotalText.text = manager.TotalClicks.ToString("0");
        }
    }

    private void UpdateText()
    {
        priceText.text = "Need " + minimumClicksToUnlockUpgrade.ToString() + " Clicks";
        amountText.text = "+" + (autoClicksPerSecond + 1).ToString() + "/s";
    }
}
