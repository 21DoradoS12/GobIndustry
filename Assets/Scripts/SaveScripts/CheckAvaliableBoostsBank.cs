using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class CheckAvaliableBoostsBank : MonoBehaviour
{
    Save save = new Save();
    private ClickOnBoosts clickOnBoosts;
    private BankResources bank;
    private PassiveIncome passive;
    private ClickOnBoostsMine clickOnBoostsMine;
    private ClickOnBoostsBarracks clickOnBoostsBarracks;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
        passive = GameObject.FindObjectOfType<PassiveIncome>();
    }
    void FixedUpdate()
    {
        Scene now_scene = SceneManager.GetActiveScene();
        clickOnBoosts = GameObject.FindObjectOfType<ClickOnBoosts>();
        clickOnBoostsMine = GameObject.FindObjectOfType<ClickOnBoostsMine>();
        clickOnBoostsBarracks = GameObject.FindObjectOfType<ClickOnBoostsBarracks>();
        if (now_scene.name == "BankUpgrades")
        {
            if (clickOnBoosts.b1 == true)
            {
                bank.boost1b = true;
            }
            if (clickOnBoosts.b2 == true)
            {
                bank.boost2b = true;
            }
            if (clickOnBoosts.b3 == true)
            {
                bank.boost3b = true;
            }
            if (clickOnBoosts.b4 == true)
            {
                bank.boost4b = true;
            }
            if (clickOnBoosts.b5 == true)
            {
                bank.boost5b = true;
            }
            if (clickOnBoosts.b6 == true)
            {
                bank.boost6b = true;
            }
            if (clickOnBoosts.b7 == true)
            {
                bank.boost7b = true;
            }
        }
        if (now_scene.name == "MineUpgrades")
        {
            if(clickOnBoostsMine.m1 == true)
            {
                bank.boost1m = true;
            }
            if (clickOnBoostsMine.m2 == true)
            {
                bank.boost2m = true;
            }
            if (clickOnBoostsMine.m3 == true)
            {
                bank.boost3m = true;
            }
            if (clickOnBoostsMine.m4 == true)
            {
                bank.boost4m = true;
            }
            if (clickOnBoostsMine.m5 == true)
            {
                bank.boost5m = true;
            }
            if (clickOnBoostsMine.m6 == true)
            {
                bank.boost6m = true;
            }
            if (clickOnBoostsMine.m7 == true)
            {
                bank.boost7m = true;
            }
        }
        if(now_scene.name == "BarrackUpgrades")
        {
            if(clickOnBoostsBarracks.s1 == true)
            {
                bank.boost1s = true;
            }
            if (clickOnBoostsBarracks.s2 == true)
            {
                bank.boost2s = true;
            }
            if (clickOnBoostsBarracks.s3 == true)
            {
                bank.boost3s = true;
            }
            if (clickOnBoostsBarracks.s4 == true)
            {
                bank.boost4s = true;
            }
            if (clickOnBoostsBarracks.s5 == true)
            {
                bank.boost5s = true;
            }
        }
    }
}
