using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariablesToText : MonoBehaviour
{
    public static double money;

    public static long stone;
    public static long copper;
    public static long tin;
    public static long iron;
    public static long silver;
    public static long gold;
    public static long quartz;
    public static long marble;
    public static long sapphire;
    public static long emerald;
    public static long ruby;
    public static long diamond;

    public static string updatebox;

    public GameObject stoneDisplay;
    public GameObject copperDisplay;
    public GameObject tinDisplay;
    public GameObject ironDisplay;
    public GameObject silverDisplay;
    public GameObject goldDisplay;

    public GameObject statusBox;
    public GameObject moneyDisplay;

    public long internalstone;
    public long internalcopper;
    public long internaltin;
    public long internaliron;
    public long internalsilver;
    public long internalgold;
    public long internalquartz;
    public long internalmarble;
    public long internalsapphire;
    public long internalemerald;
    public long internalruby;
    public long internaldiamond;



    public double internalmoney;

    // Update is called once per frame
    void Update()
    {

        internalstone = stone;
        internalcopper = copper;
        internaltin = tin;
        internaliron = iron;
        internalsilver = silver;
        internalgold = gold;
        internalquartz = quartz;
        internalmarble = marble;
        internalsapphire = sapphire;
        internalemerald = emerald;
        internalruby = ruby;
        internaldiamond = diamond;



        internalmoney = money;
        

        stoneDisplay.GetComponent<Text>().text = "Stone: " + internalstone;
        copperDisplay.GetComponent<Text>().text = "Copper: " + internalcopper;
        tinDisplay.GetComponent<Text>().text = "Tin: " + internaltin;
        ironDisplay.GetComponent<Text>().text = "Iron: " + internaliron;
        silverDisplay.GetComponent<Text>().text = "Silver: " + internalsilver;
        goldDisplay.GetComponent<Text>().text = "Gold: " + internalgold;

        statusBox.GetComponent<Text>().text = updatebox;

        moneyDisplay.GetComponent<Text>().text = "Money: " + internalmoney;


    }
}
