using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class PassiveIncomeMine : MonoBehaviour
{
    public float timemine;
    private ClickOnBoostsMine clickOnBoostsMine;
    private BankResources bank;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void Update()
    {
        timemine += Time.deltaTime;
        Scene now_scene = SceneManager.GetActiveScene();
        clickOnBoostsMine = GameObject.FindObjectOfType<ClickOnBoostsMine>();
        if (timemine > 5)
        {
            timemine -= 5;
            bank.RockToNewScene += bank.RockAppPassive;
        }
        if (now_scene.name == "MineUpgrades")
        {
            if (clickOnBoostsMine.m3 == true)
            {
                bank.boost3m = true;
            }
            if(clickOnBoostsMine.m5 == true)
            {
                bank.boost5m = true;
            }
        }
    }
}
