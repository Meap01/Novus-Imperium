using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;



public class ClickerButton : MonoBehaviour
{

    public void Clicker()
    { 
        var Random = new System.Random();
        int oreCheck = 0;
        long count = 0;

        int minrandom = 1;
        int maxrandom = 10;

        oreCheck = Random.Next(0, 100);

        switch (oreCheck)
        {

            case 1:
                count = Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.stone = VariablesToText.stone + count;
                VariablesToText.updatebox = " Stone mined: " + VariablesToText.stone ;
                break;
            case 5:
                count = Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.copper = VariablesToText.copper + Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.updatebox = " Copper mined: " + count;
                break;
            case 9:
                count = Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.tin = VariablesToText.tin + Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.updatebox = " Tin mined: " + count;
                break;
            case 60:
                count = Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.iron = VariablesToText.iron + Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.updatebox = " Iron mined: " + count;
                break;
            case 25:
                count = Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.silver = VariablesToText.silver + Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.updatebox = " Silver mined: " + count;
                break;
            case 75:
                count = Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.gold = VariablesToText.gold + Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.updatebox = " Gold mined: " + count;
                break;
            default:
                VariablesToText.stone += minrandom;
                count = minrandom;
                VariablesToText.updatebox = " stone mined: " + count;
                break;
        }
            
         

    }

}
