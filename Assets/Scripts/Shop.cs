using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject oneMinerPurchase;
    public GameObject TotalStoneMinersDisplay;
    public int StoneMinerCost = 1000;
    public static int totalStoneMiners = 0;

    public void startOneMinerPurchase()
    {
        if( VariablesToText.money >= StoneMinerCost)
        {
            oneMinerPurchase.SetActive(true);
            VariablesToText.money += -StoneMinerCost;
            totalStoneMiners++;
        }
        else
        {
            VariablesToText.updatebox = "You do not have enough money to buy a Stone Miner";
        }
        DontDestroyOnLoad(this.gameObject);


        TotalStoneMinersDisplay.GetComponent<Text>().text = "Total stone miners = " + totalStoneMiners;
    }

}
