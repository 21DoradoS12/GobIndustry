using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ChestTime : MonoBehaviour
{
    public float timer;
    private DateTime timerTime;
    public DateTime GlobalTime;
    private BankResources bank;
    private CheckTime checkTime;
    public float Chest1NewTime;
    public bool first_income;
    void Start()
    {
        checkTime = GameObject.FindObjectOfType<CheckTime>();
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void Update()
    {
        if (first_income == false)
        {
            Chest1NewTime = bank.Chest1Time;
            int recources_time = checkTime.seconds_for_recources;
            if (checkTime.havedistorbChest == false)
            {
                Chest1NewTime -= recources_time;
                checkTime.havedistorbChest = true;
            }
            first_income = true;
        }
        if(bank.Chest1Time != 0 && bank.Chest1Time > 0)
        {
            Chest1NewTime = Chest1NewTime - Time.deltaTime;
            bank.Chest1Time = (int)Chest1NewTime;
        }
    }
}
