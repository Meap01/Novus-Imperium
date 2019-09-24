using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;



public class MainClickBehaviour : MonoBehaviour
{

    public void Clicker()
    { 
        var Random = new System.Random();
        int oreCheck = 0;

        oreCheck = Random.Next(1, 100);

        switch (oreCheck)
        {
            case 1:
                GlobalImperium.stone = GlobalImperium.stone + Random.Next(1, 10) + 1;
                break;
            case 5:
                GlobalImperium.copper = GlobalImperium.copper + Random.Next(1, 10) + 1;
                break;
            case 9:
                GlobalImperium.tin = GlobalImperium.tin + Random.Next(1, 10) + 1;
                break;
            case 11:
                GlobalImperium.iron = GlobalImperium.iron + Random.Next(1, 10) + 1;
                break;
            case 25:
                GlobalImperium.silver = GlobalImperium.silver + Random.Next(1, 10) + 1;
                break;
            case 58:
                GlobalImperium.gold = GlobalImperium.gold + Random.Next(1, 10) + 1;
                break;
            default:
                GlobalImperium.stone++;
                break;
        }
            
         

    }

}
