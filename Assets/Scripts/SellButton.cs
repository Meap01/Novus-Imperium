﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;



public class SellButton : MonoBehaviour
{

    int copperValue = 5;
    int tinValue = 10;
    int ironValue = 25;
    int silverValue = 50;
    int goldValue = 100;

    public void Seller()
    {
        long count = 0;

        VariablesToText.money = VariablesToText.money + VariablesToText.stone + (VariablesToText.copper * copperValue) + (VariablesToText.tin * tinValue) + (VariablesToText.iron * ironValue) + (VariablesToText.silver * silverValue) + (VariablesToText.gold * goldValue);

        count = VariablesToText.stone + (VariablesToText.copper * 5) +(VariablesToText.tin * 10) +(VariablesToText.iron * 25) +(VariablesToText.silver * 50) +(VariablesToText.gold * 100);
        VariablesToText.updatebox = "Money recieved from selling all +" + count;

        VariablesToText.stone = 0;
        VariablesToText.copper = 0;
        VariablesToText.tin = 0;
        VariablesToText.iron = 0;
        VariablesToText.silver = 0;
        VariablesToText.gold = 0;

    }

}
