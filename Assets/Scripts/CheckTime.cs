using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CheckTime : MonoBehaviour
{
    public DateTime GlobalTime;
    private BankResources bank;
    public long seconds_for_recources;
    public float Seconds_to_chest;
    public bool havedistorbChest = false;
    public bool havedistorbDungeon = false;
    private EnternetCheck enternet;
    public long OfflineEarn;
    public TimeSpan Total_Offline_Time;
    public long CoinGain;
    public long RockGain;
    public long SoldiersGain;
    private void Start()
    {
        enternet = GameObject.FindObjectOfType<EnternetCheck>();
        if (enternet.InternetOff == false)
        {
            bank = GameObject.FindObjectOfType<BankResources>();
            DateTime exitTime = DateTime.Parse(bank.exitTime);
            var dateTime = CheckGlobalTime();
            GlobalTime = dateTime;
            Total_Offline_Time = GlobalTime.Subtract(exitTime);
            double Seconds_Offline = Total_Offline_Time.TotalSeconds;
            seconds_for_recources = Convert.ToInt32(Seconds_Offline);
            OfflineEarn = seconds_for_recources * bank.BoostOfflineEarn;
            if (Seconds_Offline <= bank.MaxOfflineTime)
            {
                CoinGain = OfflineEarn;
                RockGain = OfflineEarn;
                SoldiersGain = OfflineEarn / 100;
            }
            if (Seconds_Offline > bank.MaxOfflineTime)
            {
                CoinGain = bank.MaxOfflineTime * bank.BoostOfflineEarn;
                RockGain = bank.MaxOfflineTime * bank.BoostOfflineEarn;
                SoldiersGain = (bank.MaxOfflineTime * bank.BoostOfflineEarn) / 100;
            }
            bank.MoneyToNewScene += CoinGain;
            bank.RockToNewScene += RockGain;
            bank.SoldiersToNewScene += SoldiersGain;
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
    private void FixedUpdate()
    {
    }
}