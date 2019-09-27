using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;


public class MinerInformationWindow : MonoBehaviour
{
    public GameObject minerWindow;
    public GameObject closeMinerWindow;


    public void MinerInformation()
    {
        minerWindow.SetActive(true);

    }

    public void closeMinerInformation()
    {
        closeMinerWindow.SetActive(false);

    }




}
