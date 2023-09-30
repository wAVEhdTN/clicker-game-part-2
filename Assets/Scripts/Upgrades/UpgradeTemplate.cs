using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UpgradeTemplate : MonoBehaviour
{
    private Manager manager;

    public int minimumClicksToUnlockUpgrade; //Price
    public TextMeshProUGUI priceText;

    //private bool hasUpgrade; //(ONLY ADD THIS IF YOUR UPGRADE IS A ONE-TIME PURCHASE ONLY)

    private void Start()
    {
        manager = Manager.instance; //First, get the instance of the manager

        UpdateText(); //Set the price text
    }

    public void BuyUpgrade()
    {
        //Check whether you have enough clicks or not 
        if (manager.TotalClicks >= minimumClicksToUnlockUpgrade)
        {
            manager.TotalClicks -= minimumClicksToUnlockUpgrade; //If true, subtract the price from the total clicks

            #region ONLY ADD THIS IF YOUR UPGRADE IS A ONE-TIME PURCHASE ONLY
            //hasUpgrade = true;
            //GetComponent<Button>().interactable = false;
            #endregion

            //Here, add whatever function your upgrade allows!
        }
    }
    private void UpdateText()
    {
        priceText.text = "Need " + minimumClicksToUnlockUpgrade.ToString() + " Clicks";
    }
}
