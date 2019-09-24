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
        long count = 0;

        oreCheck = Random.Next(1, 100);

        switch (oreCheck)
        {
            case 1:
                count = Random.Next(1, 10) + 1;
                GlobalImperium.stone = GlobalImperium.stone + count;
                GlobalImperium.updatebox = " Stone mined: " + GlobalImperium.stone ;
                break;
            case 5:
                count = Random.Next(1, 10) + 1;
                GlobalImperium.copper = GlobalImperium.copper + Random.Next(1, 10) + 1;
                GlobalImperium.updatebox = " Copper mined: " + count;
                break;
            case 9:
                count = Random.Next(1, 10) + 1;
                GlobalImperium.tin = GlobalImperium.tin + Random.Next(1, 10) + 1;
                GlobalImperium.updatebox = " Tin mined: " + count;
                break;
            case 11:
                count = Random.Next(1, 10) + 1;
                GlobalImperium.iron = GlobalImperium.iron + Random.Next(1, 10) + 1;
                GlobalImperium.updatebox = " Iron mined: " + count;
                break;
            case 25:
                count = Random.Next(1, 10) + 1;
                GlobalImperium.silver = GlobalImperium.silver + Random.Next(1, 10) + 1;
                GlobalImperium.updatebox = " Silver mined: " + count;
                break;
            case 58:
                count = Random.Next(1, 10) + 1;
                GlobalImperium.gold = GlobalImperium.gold + Random.Next(1, 10) + 1;
                GlobalImperium.updatebox = " Gold mined: " + count;
                break;
            default:
                GlobalImperium.stone++;
                count = 1;
                GlobalImperium.updatebox = " stone mined: " + count;
                break;
        }
            
         

    }

}
