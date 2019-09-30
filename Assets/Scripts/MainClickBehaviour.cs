using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;



public class MainClickBehaviour : MonoBehaviour
{
    public static int minrandom = 1;
    public static int maxrandom = 10;

    public double stoneRoundAdd;
    public double copperRoundAdd;
    public double tinRoundAdd;
    public double ironRoundAdd;
    public double silverRoundAdd;
    public double goldRoundAdd;

    /*
    Shop.TotalEnhancedClick = 100%
    if: Shop.TotalEnhanced Click = 2 , they make 110 
    therefore 1 = 100%
                1.1 = 110%
                 which means we need to get 10% from that 100% and add it to the 100%
                Shop.TotalEnhancedClick  * 0.1 = 10%
                Shop.TotalEnhancedClick + (Shop.TotalEnhancedClick * 0.1) = 100% + 10% = 110%

*/

    public void Clicker()
    { 
        var Random = new System.Random();
        double oreCheck = 0;
        double count = 0;
        
        // enters if statement correctly. 
        if (Shop.TotalEnhancedClick >= 0.1)
        {
            double EnhancedClickMultiplier = Shop.TotalEnhancedClick + (Shop.TotalEnhancedClick * 0.1);
            double countMultiplied = count;

            
            
            oreCheck = Random.Next(0, 150);

            switch (oreCheck)
            {

                case 1:
                    count = Random.Next(minrandom, maxrandom) + minrandom;
                    countMultiplied = count + (count * EnhancedClickMultiplier);
                    VariablesToText.stone = VariablesToText.stone + countMultiplied;
                    VariablesToText.updatebox = "Bonus Stone +" + count + "." + (countMultiplied - count);
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    count = Random.Next(minrandom, maxrandom) + minrandom;
                    countMultiplied = count + (count * EnhancedClickMultiplier);
                    VariablesToText.copper = VariablesToText.copper + countMultiplied;
                    VariablesToText.updatebox = "Copper +" + count + " + " + (countMultiplied - count);
                    break;
                case 7:
                case 8:    
                case 9:
                case 10:
                    count = Random.Next(minrandom, maxrandom) + minrandom;
                    countMultiplied = count + (count * EnhancedClickMultiplier);
                    VariablesToText.tin = VariablesToText.tin + countMultiplied;
                    VariablesToText.updatebox = "Tin +" + count + " + " + (countMultiplied - count);
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                    count = Random.Next(minrandom, maxrandom) + minrandom;
                    countMultiplied = count + (count * EnhancedClickMultiplier);
                    VariablesToText.iron = VariablesToText.iron + countMultiplied;
                    VariablesToText.updatebox = "Iron +" + count + " + " + (countMultiplied - count);
                    break;
                case 24:
                case 26:
                case 27:
                case 25:
                    count = Random.Next(minrandom, maxrandom) + minrandom;
                    countMultiplied = count + (count * EnhancedClickMultiplier);
                    VariablesToText.silver = VariablesToText.silver + countMultiplied;
                    VariablesToText.updatebox = "Silver +" + count + " + " + (countMultiplied - count);
                    break;
                case 56:
                case 57:
                case 58:
                    count = Random.Next(minrandom, maxrandom) + minrandom;
                    countMultiplied = count + (count * EnhancedClickMultiplier);
                    VariablesToText.gold = VariablesToText.gold + countMultiplied;
                    VariablesToText.updatebox = "Gold +" + count + " + " + (countMultiplied - count);
                    break;
                default:
                    VariablesToText.stone += minrandom + (minrandom * EnhancedClickMultiplier);
                    count = minrandom;
                    countMultiplied = count + (count * EnhancedClickMultiplier);
                    VariablesToText.updatebox = "Stone +" + count + " + " + (countMultiplied - count);
                    break;

                    /*
                    default:
                    VariablesToText.stone += minrandom;
                    count = minrandom;
                    VariablesToText.updatebox = "Stone +" + count;
                    break;
                    */
            }
        }
        else
        {
            oreCheck = Random.Next(0, 100);

            switch (oreCheck)
            {

                case 1:
                    count = Random.Next(minrandom, maxrandom) + minrandom;
                    VariablesToText.stone = VariablesToText.stone + count;
                    VariablesToText.updatebox = "Bonus Stone +" + count;
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    count = Random.Next(minrandom, maxrandom) + minrandom;
                    VariablesToText.copper = VariablesToText.copper + count;
                    VariablesToText.updatebox = "Copper +" + count;
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                    count = Random.Next(minrandom, maxrandom) + minrandom;
                    VariablesToText.tin = VariablesToText.tin + count;
                    VariablesToText.updatebox = "Tin +" + count;
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                    count = Random.Next(minrandom, maxrandom) + minrandom;
                    VariablesToText.iron = VariablesToText.iron + count;
                    VariablesToText.updatebox = "Iron +" + count;
                    break;
                case 24:
                case 26:
                case 27:
                case 25:
                    count = Random.Next(minrandom, maxrandom) + minrandom;
                    VariablesToText.silver = VariablesToText.silver + count;
                    VariablesToText.updatebox = "Silver +" + count;
                    break;
                case 56:
                case 57:
                case 58:
                    count = Random.Next(minrandom, maxrandom) + minrandom;
                    VariablesToText.gold = VariablesToText.gold + count;
                    VariablesToText.updatebox = "Gold +" + count;
                    break;
                default:
                    VariablesToText.stone += minrandom;
                    count = minrandom;
                    VariablesToText.updatebox = "Stone +" + count;
                    break;
            }
        }   
         

    }

}
