using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public double money;

    public double stone;
    public double copper;
    public double tin;
    public double iron;
    public double silver;
    public double gold;
    public double quartz;
    public double marble;
    public double sapphire;
    public double emerald;
    public double ruby;
    public double diamond;

    public int totalStoneMiners = 0;
    public int totalCopperMiners = 0;
    public int totalTinMiners = 0;
    public int totalIronMiners = 0;
    public int totalSilverMiners = 0;
    public int totalGoldMiners = 0;

    public double TotalEnhancedClick = 0;

    public double StoneMinerCost;
    public double CopperMinerCost;
    public double TinMinerCost;
    public double IronMinerCost;
    public double SilverMinerCost;
    public double GoldMinerCost;
    public double EnhancedClickCost;

    public PlayerData (VariablesToText player)
    {
        money = VariablesToText.money;

        stone = VariablesToText.stone;
        copper = VariablesToText.copper;
        tin = VariablesToText.tin;
        iron = VariablesToText.iron;
        silver = VariablesToText.silver;
        gold = VariablesToText.gold;
        quartz = VariablesToText.quartz;
        marble = VariablesToText.marble;
        sapphire  = VariablesToText.sapphire;
        emerald  = VariablesToText.emerald;
        ruby  = VariablesToText.ruby;
        diamond  = VariablesToText.diamond;

        totalStoneMiners = Shop.totalStoneMiners;
        totalCopperMiners = Shop.totalCopperMiners;
        totalTinMiners = Shop.totalTinMiners;
        totalIronMiners = Shop.totalIronMiners;
        totalSilverMiners = Shop.totalSilverMiners;
        totalGoldMiners = Shop.totalGoldMiners;

        TotalEnhancedClick = Shop.TotalEnhancedClick;

        StoneMinerCost = Shop.StoneMinerCost;
        CopperMinerCost = Shop.CopperMinerCost;
        TinMinerCost = Shop.TinMinerCost;
        IronMinerCost = Shop.IronMinerCost;
        SilverMinerCost = Shop.SilverMinerCost;
        GoldMinerCost = Shop.GoldMinerCost;
        EnhancedClickCost = Shop.EnhancedClickCost;

    }
}
