using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;



public class SellButton : MonoBehaviour
{
    public static int stoneValue = 1;
    public static int copperValue = 5;
    public static int tinValue = 10;
    public static int ironValue = 25;         // sale value of a single element
    public static int silverValue = 50;
    public static int goldValue = 100;

    public void Seller()
    {
        long count = 0; // used to count the total money you get from a sale

        VariablesToText.money = VariablesToText.money + (VariablesToText.stone * stoneValue) + (VariablesToText.copper * copperValue) + (VariablesToText.tin * tinValue) + (VariablesToText.iron * ironValue) + (VariablesToText.silver * silverValue) + (VariablesToText.gold * goldValue);

        count = (VariablesToText.stone * stoneValue) + (VariablesToText.copper * copperValue) +(VariablesToText.tin * tinValue) +(VariablesToText.iron * ironValue) +(VariablesToText.silver * silverValue) +(VariablesToText.gold * goldValue);
        VariablesToText.updatebox = "Money recieved from selling all +" + count;  

        VariablesToText.stone = 0;
        VariablesToText.copper = 0;
        VariablesToText.tin = 0;
        VariablesToText.iron = 0;  // sets all the values to 0 as they were sold for money
        VariablesToText.silver = 0;
        VariablesToText.gold = 0;

    }

}
