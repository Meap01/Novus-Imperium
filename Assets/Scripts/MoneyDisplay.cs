using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{
    public GameObject moneyDisplay;

    public double internalmoney;
    // Update is called once per frame
    void Update()
    {

        internalmoney = VariablesToText.money;

        moneyDisplay.GetComponent<Text>().text = "Money: " + internalmoney;  // used in the shop to display the money
    }
}
