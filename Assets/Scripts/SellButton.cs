using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;



public class SellButton : MonoBehaviour
{

    public void Seller()
    { 
        GlobalImperium.money = GlobalImperium.money + GlobalImperium.stone;
        

        GlobalImperium.money = GlobalImperium.money + (GlobalImperium.copper * 5);


        GlobalImperium.money = GlobalImperium.money + (GlobalImperium.tin * 10);


        GlobalImperium.money = GlobalImperium.money + (GlobalImperium.iron * 25);


        GlobalImperium.money = GlobalImperium.money + (GlobalImperium.silver * 50);


        GlobalImperium.money = GlobalImperium.money + (GlobalImperium.gold * 100);

        

        GlobalImperium.stone = 0;
        GlobalImperium.copper = 0;
        GlobalImperium.tin = 0;
        GlobalImperium.iron = 0;
        GlobalImperium.silver = 0;
        GlobalImperium.gold = 0;









    }

}
