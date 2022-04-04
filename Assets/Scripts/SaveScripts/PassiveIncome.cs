using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading;
using System.IO;

public class PassiveIncome : MonoBehaviour
{
    public DateTime TimeOnPause;
    public DateTime TimeOffPause;
    public TimeSpan Total_Pause_Time;
    public float timebank;
    public float timerecruit;
    public float timemine;
    public int passiveIncomePause;
    public int passiveIncomePauseOriginal;
    private ClickOnBoosts clickOnBoosts;
    private ClickOnBoostsMine clickOnBoostsMine;
    private ClickOnBoostsBarracks clickOnBoostsBarracks;
    private BankResources bank;
    public bool GainPause;
    public bool FirstPause;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    private void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            var dateTime = CheckGlobalTime();
            TimeOffPause = dateTime;
        }
        if (!pause)
        {
            var dateTime = CheckGlobalTime();
            TimeOnPause = dateTime;
            GainPause = false;
            FirstPause = true;
        }
    }
    void Update()
    {
        timebank += Time.deltaTime;
        timemine += Time.deltaTime;
        timerecruit += Time.deltaTime;
        Scene now_scene = SceneManager.GetActiveScene();
        clickOnBoosts = GameObject.FindObjectOfType<ClickOnBoosts>();
        clickOnBoostsMine = GameObject.FindObjectOfType<ClickOnBoostsMine>();
        clickOnBoostsBarracks = GameObject.FindObjectOfType<ClickOnBoostsBarracks>();
        if (timebank > 1)
        {
            timebank -= 1;
            bank.MoneyToNewScene += bank.CoinAppPassive;
        }
        if (timemine > 5)
        {
            timemine -= 5;
            bank.RockToNewScene += bank.RockAppPassive;
        }
        if (timerecruit > 5)
        {
            timerecruit -= 5;
            bank.SoldiersToNewScene += bank.SoldiersAppPassive;
        }
        if (GainPause == false && FirstPause == true)
        {
            Total_Pause_Time = TimeOnPause.Subtract(TimeOffPause);
            double Seconds_Offline = Total_Pause_Time.TotalSeconds;
            passiveIncomePauseOriginal = Convert.ToInt32(Seconds_Offline);
            passiveIncomePause = passiveIncomePauseOriginal * bank.CoinAppPassive;
            bank.MoneyToNewScene += passiveIncomePause;
            passiveIncomePause = (passiveIncomePauseOriginal / 5) * bank.RockAppPassive;
            bank.RockToNewScene += passiveIncomePause;
            passiveIncomePause = (passiveIncomePauseOriginal / 5) * bank.SoldiersAppPassive;
            bank.SoldiersToNewScene += passiveIncomePause;
            GainPause = true;
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
        if (now_scene.name == "MineUpgrades")
        {
            if (clickOnBoostsMine.m3 == true)
            {
                bank.boost3m = true;
            }
            if (clickOnBoostsMine.m5 == true)
            {
                bank.boost5m = true;
            }
        }
        if (now_scene.name == "BarrackUpgrades")
        {
            if (clickOnBoostsBarracks.s5 == true)
            {
                bank.boost5s = true;
            }
        }
    }
    DateTime CheckGlobalTime()
    {
        var www = new WWW("https://sm174.ru");
        while (!www.isDone && www.error == null)
            Thread.Sleep(1);

        var str = www.responseHeaders["Date"];
        DateTime dateTime;

        if (!DateTime.TryParse(str, out dateTime))
            return DateTime.MinValue;

        return dateTime.ToUniversalTime();
    }
}
