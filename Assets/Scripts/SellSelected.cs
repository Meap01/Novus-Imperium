using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SellSelected : MonoBehaviour
{
    public bool StoneButton = true;
    public bool SilverButton = true;
    public bool TinButton = true;
    public bool IronButton = true;
    public bool CopperButton = true;
    public bool GoldButton = true;
    public long count = 0; // used to count the total money you get from a sale // Copying Danielius pog

    // Update is called once per frame

    public void SellStone()
    {

        if (StoneButton == true)
        {
            count = 0;
            VariablesToText.money = VariablesToText.money + VariablesToText.stone;
            count = count + (VariablesToText.stone * SellButton.stoneValue);
            
            if(VariablesToText.stone > 0)
            {
                VariablesToText.updatebox = "Money received from selling stone: " + count;
            }
            else
            {
                VariablesToText.updatebox = "You have 0 stone to sell";
            }
            VariablesToText.stone = 0;

        }
    }

    public void SellSilver()
    {
        if (SilverButton == true)
        {
            count = 0;
            VariablesToText.money = VariablesToText.money + (VariablesToText.silver * SellButton.silverValue);
            count = count + (VariablesToText.silver * SellButton.silverValue);
            
            if (VariablesToText.stone > 0)
            {
                VariablesToText.updatebox = "Money received from selling silver: " + count;
            }
            else
            {
                VariablesToText.updatebox = "You have 0 silver to sell";
            }
            VariablesToText.silver = 0;
        }
    }

    public void SellTin()
    {
        if (TinButton == true)
        {
            count = 0;
            VariablesToText.money = VariablesToText.money + (VariablesToText.tin * SellButton.tinValue);
            count = count + (VariablesToText.tin * SellButton.tinValue);
            
            if (VariablesToText.tin > 0)
            {
                VariablesToText.updatebox = "Money received from selling Tin: " + count;
            }
            else
            {
                VariablesToText.updatebox = "You have 0 Tin to sell";
            }
            VariablesToText.tin = 0;
        }
    }

    public void SellIron()
    {
        if (IronButton == true)
        {
            count = 0;
            VariablesToText.money = VariablesToText.money + (VariablesToText.iron * SellButton.ironValue);
            count = count + (VariablesToText.iron * SellButton.ironValue);
            
            if (VariablesToText.iron > 0)
            {
                VariablesToText.updatebox = "Money received from selling iron: " + count;
            }
            else
            {
                VariablesToText.updatebox = "You have 0 iron to sell";
            }
            VariablesToText.iron = 0;
        }
    }

    public void SellCopper()
    {
        if (CopperButton == true)
        {
            count = 0;
            VariablesToText.money = VariablesToText.money + (VariablesToText.copper * SellButton.copperValue);
            count = count + (VariablesToText.copper * SellButton.copperValue);
            
            if (VariablesToText.copper > 0)
            {
                VariablesToText.updatebox = "Money received from selling copper: " + count;
            }
            else
            {
                VariablesToText.updatebox = "You have 0 copper to sell";
            }
            VariablesToText.copper = 0;
        }
    }
    public void SellGold()
    {
        if (GoldButton == true)
        {
            count = 0;
            VariablesToText.money = VariablesToText.money + (VariablesToText.gold * SellButton.goldValue);
            count = count + (VariablesToText.gold * SellButton.goldValue);
            
            if (VariablesToText.gold > 0)
            {
                VariablesToText.updatebox = "Money received from selling gold: " + count;
            }
            else
            {
                VariablesToText.updatebox = "You have 0 gold to sell";
            }
            VariablesToText.gold = 0;
        }
    }
}
