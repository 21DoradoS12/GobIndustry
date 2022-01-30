using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
public class UpdateRock : MonoBehaviour
{
    public Text RockText;
    private BankResources bank;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void Update()
    {
        RockText.text = bank.RockToNewScene.ToString();
    }
}
