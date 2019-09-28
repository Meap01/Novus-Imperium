using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ShopAutoMine : MonoBehaviour
{


    public bool stoneMiner = false;
    public bool TinMiner = false;
    public bool CopperMiner = false;
    public bool IronMiner = false;
    public bool SilverMiner = false;
    public bool GoldMiner = false;

    // Update is called once per frame

    void Update()
    {
        if (stoneMiner == false)
        {
            stoneMiner = true;
            StartCoroutine(OneStoneMiner());
        }
        if (CopperMiner == false)
        {
            CopperMiner = true;
            StartCoroutine(OneCopperMiner());
        }
        if (TinMiner == false)
        {
            TinMiner = true;
            StartCoroutine(OneTinMiner());
        }
        if (IronMiner == false)
        {
            IronMiner = true;
            StartCoroutine(OneIronMiner());
        }
        if (SilverMiner == false)
        {
            SilverMiner = true;
            StartCoroutine(OneSilverMiner());
        }
        if (GoldMiner == false)
        {
            GoldMiner = true;
            StartCoroutine(OneGoldMiner());
        }
    }
    IEnumerator OneStoneMiner()
    {

         VariablesToText.stone += Shop.totalStoneMiners;
         yield return new WaitForSeconds(1);
         stoneMiner = false;

    }
    IEnumerator OneCopperMiner()
    {

        VariablesToText.copper += Shop.totalCopperMiners;
        yield return new WaitForSeconds(1);
        CopperMiner = false;

    }
    IEnumerator OneTinMiner()
    {

        VariablesToText.tin += Shop.totalTinMiners;
        yield return new WaitForSeconds(1);
        TinMiner = false;

    }
    IEnumerator OneIronMiner()
    {

        VariablesToText.iron += Shop.totalIronMiners;
        yield return new WaitForSeconds(1);
        IronMiner = false;

    }
    IEnumerator OneSilverMiner()
    {

        VariablesToText.silver += Shop.totalSilverMiners;
        yield return new WaitForSeconds(1);
        SilverMiner = false;

    }
    IEnumerator OneGoldMiner()
    {

        VariablesToText.gold += Shop.totalGoldMiners;
        yield return new WaitForSeconds(1);
        GoldMiner = false;

    }

}