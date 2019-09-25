using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ShopAutoMine : MonoBehaviour
{


    public bool stoneMiner = false;
    public static int MinerIncrease = 1;
    public int InternalIncrase = MinerIncrease;
    // Update is called once per frame
    void Update()
    {
        if (stoneMiner == false)
        {
            stoneMiner = true;
            StartCoroutine(oneStoneMiner());
        }
        DontDestroyOnLoad(this.gameObject);
    }
    IEnumerator oneStoneMiner()
    {
        VariablesToText.stone += MinerIncrease;
        yield return new WaitForSeconds(1);
        stoneMiner = false;
        DontDestroyOnLoad(this.gameObject);
    }
    
}