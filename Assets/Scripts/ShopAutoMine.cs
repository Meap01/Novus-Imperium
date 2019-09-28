using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ShopAutoMine : MonoBehaviour
{


    public bool stoneMiner = false;
    public static int MinerIncrease = 0;
    public int InternalIncrase = MinerIncrease;
    // Update is called once per frame
    private void Start()
    {

    }
    void Update()
    {
          if (stoneMiner == false)
          {
              stoneMiner = true;
              StartCoroutine(oneStoneMiner());
          }
    }
    IEnumerator oneStoneMiner()
    {

         VariablesToText.stone += Shop.totalStoneMiners;
         yield return new WaitForSeconds(1);
         stoneMiner = false;

    }
    
}