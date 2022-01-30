using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class PassiveIncome : MonoBehaviour
{
    public float timebank;
    private ClickOnBoosts clickOnBoosts;
    private BankResources bank;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void Update()
    {
        timebank += Time.deltaTime;
        Scene now_scene = SceneManager.GetActiveScene();
        clickOnBoosts = GameObject.FindObjectOfType<ClickOnBoosts>();
        if (timebank > 1)
        {
            timebank -= 1;
            bank.MoneyToNewScene += bank.CoinAppPassive;
        }
        if (now_scene.name == "BankUpgrades")
        {
            if (clickOnBoosts.b3 == true)
            {
                bank.boost3b = true;
            }
            if (clickOnBoosts.b5 == true)
            {
                bank.boost5b = true;
            }
        }
    }
}
