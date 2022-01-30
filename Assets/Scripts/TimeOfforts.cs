using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeOfforts : MonoBehaviour
{
    private BankResources bank;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void Update()
    {
        DateTime exitDate = DateTime.Now;
        exitDate = exitDate.ToUniversalTime();
        string exitDate1 = exitDate.ToString();
        bank.exitTime = exitDate1;
    }
}
