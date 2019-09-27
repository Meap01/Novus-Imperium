using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SellChooseButton : MonoBehaviour
{
    public GameObject SellWindow;
    public GameObject SellChosenButton;
    public GameObject SellButton;

    // Start is called before the first frame update
    void Start()
    {
        SellWindow.SetActive(true);
        SellChosenButton.SetActive(true);
        SellButton.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        SellWindow.SetActive(false);
        SellChosenButton.SetActive(false);
        SellButton.SetActive(false);
    }
}
