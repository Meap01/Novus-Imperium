using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariablesToText : MonoBehaviour
{
    public static double money; //  Money variable for whole project

    public static double stone;
    public static double copper;
    public static double tin;
    public static double iron;
    public static double silver;
    public static double gold;
    public static double quartz;              // global element variables for whole project
    public static double marble;
    public static double sapphire;
    public static double emerald;
    public static double ruby;
    public static double diamond;
        
    public static string updatebox;                 // global element for the update bar, for whole project

    public GameObject stoneDisplay;
    public GameObject copperDisplay;
    public GameObject tinDisplay;        //game objects to display the ammount of each
    public GameObject ironDisplay;
    public GameObject silverDisplay;
    public GameObject goldDisplay;

    public GameObject statusBox;
    public GameObject moneyDisplay;

    public double internalstone;
    public double internalcopper;
    public double internaltin;
    public double internaliron;
    public double internalsilver;
    public double internalgold;
    public double internalquartz;             // internal values of each
    public double internalmarble;
    public double internalsapphire;
    public double internalemerald;
    public double internalruby;
    public double internaldiamond;



    public double internalmoney;

    public void SaveGame()
    {
        SaveSystem.SaveGame(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        money = data.money;

        stone = data.stone;
        copper = data.copper;
        tin = data.tin;
        iron = data.iron;
        silver = data.silver;
        gold = data.gold;
        quartz = data.quartz;
        marble = data.marble;
        sapphire = data.sapphire;
        emerald = data.emerald;
        ruby = data.ruby;
        diamond = data.diamond;

        Shop.totalStoneMiners = data.totalStoneMiners;
        Shop.totalCopperMiners = data.totalCopperMiners;
        Shop.totalTinMiners = data.totalTinMiners;
        Shop.totalIronMiners = data.totalIronMiners;
        Shop.totalSilverMiners = data.totalSilverMiners;
        Shop.totalGoldMiners = data.totalGoldMiners;

        Shop.TotalEnhancedClick = data.TotalEnhancedClick;


    }





    // Update is called once per frame
    void Update()
    {

        internalstone = stone;
        internalcopper = copper;
        internaltin = tin;
        internaliron = iron;
        internalsilver = silver;
        internalgold = gold;                    //internal values get the global values
        internalquartz = quartz;
        internalmarble = marble;
        internalsapphire = sapphire;
        internalemerald = emerald;
        internalruby = ruby;
        internaldiamond = diamond;



        internalmoney = Math.Round(money, 2);
        internalstone = Math.Ceiling(stone);
        internalcopper = Math.Ceiling(copper);
        internaltin = Math.Ceiling(tin);
        internaliron = Math.Ceiling(iron);
        internalsilver = Math.Ceiling(silver);
        internalgold = Math.Ceiling(gold);


        stoneDisplay.GetComponent<Text>().text = "Stone: " + internalstone;
        copperDisplay.GetComponent<Text>().text = "Copper: " + internalcopper;
        tinDisplay.GetComponent<Text>().text = "Tin: " + internaltin;                           // shows the values to the user
        ironDisplay.GetComponent<Text>().text = "Iron: " + internaliron;
        silverDisplay.GetComponent<Text>().text = "Silver: " + internalsilver;
        goldDisplay.GetComponent<Text>().text = "Gold: " + internalgold;

        statusBox.GetComponent<Text>().text = updatebox;

        moneyDisplay.GetComponent<Text>().text = "Money: " + internalmoney;


    }
}
