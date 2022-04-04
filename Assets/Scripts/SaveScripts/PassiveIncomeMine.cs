using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading;
using System.IO;

public class PassiveIncomeMine : MonoBehaviour
{
    public DateTime TimeOnPause;
    public DateTime TimeOffPause;
    public TimeSpan Total_Pause_Time;
    public float timemine;
    public int passiveIncomePause;
    private ClickOnBoostsMine clickOnBoostsMine;
    private BankResources bank;
    public bool GainPause;
    public bool FirstPause;
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
        if (GainPause == false && FirstPause == true)
        {
            Total_Pause_Time = TimeOnPause.Subtract(TimeOffPause);
            double Seconds_Offline = Total_Pause_Time.TotalSeconds;
            passiveIncomePause = Convert.ToInt32(Seconds_Offline);
            passiveIncomePause = passiveIncomePause * bank.RockAppPassive;
            bank.RockToNewScene += passiveIncomePause;
            GainPause = true;
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
