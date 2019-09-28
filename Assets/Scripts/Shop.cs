using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject oneMinerPurchase;
    public GameObject TotalStoneMinersDisplay;
    public GameObject TextStoneMinerCost;

    public static int StoneMinerCost = 1000;
    public static int totalStoneMiners = 0;

    void Start()
    {
        TotalStoneMinersDisplay.GetComponent<Text>().text = "Total stone miners = " + totalStoneMiners;
        TextStoneMinerCost.GetComponent<Text>().text = "Stone Miner:" + StoneMinerCost;
    }

    public void startOneMinerPurchase()
    {
         if (VariablesToText.money >= StoneMinerCost)
         {

            oneMinerPurchase.SetActive(true);
            VariablesToText.money += -StoneMinerCost;
            VariablesToText.updatebox = "Miner bought for " + StoneMinerCost;
            StoneMinerCost += 100;
            totalStoneMiners++;
            TotalStoneMinersDisplay.GetComponent<Text>().text = "Total stone miners = " + totalStoneMiners;

         }
         else
         {
             VariablesToText.updatebox = "You do not have enough money to buy a Stone Miner";
         }
         TextStoneMinerCost.GetComponent<Text>().text = "Stone Miner:" + StoneMinerCost;
        
    }

    public void KeepOneGameObjectRunning()
    {
        Destroy(oneMinerPurchase);
    }

}
