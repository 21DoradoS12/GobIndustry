using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading;
using System.IO;

public class PassiveIncomeBarracks : MonoBehaviour
{
    public DateTime TimeOnPause;
    public DateTime TimeOffPause;
    public TimeSpan Total_Pause_Time;
    public float timerecruit;
    public int passiveIncomePause;
    private ClickOnBoostsBarracks clickOnBoostsBarracks;
    private BankResources bank;
    public bool GainPause;
    public bool FirstPause;
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
        if (GainPause == false && FirstPause == true)
        {
            Total_Pause_Time = TimeOnPause.Subtract(TimeOffPause);
            double Seconds_Offline = Total_Pause_Time.TotalSeconds;
            passiveIncomePause = Convert.ToInt32(Seconds_Offline);
            passiveIncomePause = passiveIncomePause * bank.SoldiersAppPassive;
            bank.SoldiersToNewScene += passiveIncomePause;
            GainPause = true;
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
