using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class PassiveIncomeBarracks : MonoBehaviour
{
    public float timerecruit;
    private ClickOnBoostsBarracks clickOnBoostsBarracks;
    private BankResources bank;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void Update()
    {
        timerecruit += Time.deltaTime;
        Scene now_scene = SceneManager.GetActiveScene();
        clickOnBoostsBarracks = GameObject.FindObjectOfType<ClickOnBoostsBarracks>();
        if (timerecruit > 5)
        {
            timerecruit -= 5;
            bank.SoldiersToNewScene += bank.SoldiersAppPassive;
        }
        if (now_scene.name == "BarrackUpgrades")
        {
            if (clickOnBoostsBarracks.s5 == true)
            {
                bank.boost5s = true;
            }
        }
    }
}
