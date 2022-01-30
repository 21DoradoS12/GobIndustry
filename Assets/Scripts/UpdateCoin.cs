using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class UpdateCoin : MonoBehaviour
{
    public Text MoneyText;
    private BankResources bank;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void Update()
    {
        MoneyText.text = bank.MoneyToNewScene.ToString();
    }
}

