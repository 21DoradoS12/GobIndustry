using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CheckTime : MonoBehaviour
{
    public DateTime GlobalTime;
    public DateTime RealExitTime;
    private BankResources bank;
    public int seconds_for_recources;
    public float Seconds_to_chest;
    public bool havedistorbChest = false;
    public bool havedistorbDungeon = false;
    private EnternetCheck enternet;
    public int OfflineEarn;
    public TimeSpan Total_Offline_Time;
    public int CoinGain;
    public int RockGain;
    public int SoldiersGain;
    private void Start()
    {
        enternet = GameObject.FindObjectOfType<EnternetCheck>();
        if (enternet.InternetOff == false)
        {
            bank = GameObject.FindObjectOfType<BankResources>();
            DateTime exitTime = DateTime.Parse(bank.exitTime);
            RealExitTime = DateTime.Parse(bank.exitTime);
            var dateTime = CheckGlobalTime();
            GlobalTime = dateTime;
            Total_Offline_Time = GlobalTime.Subtract(exitTime);
            double Seconds_Offline = Total_Offline_Time.TotalSeconds;
            seconds_for_recources = Convert.ToInt32(Seconds_Offline);
            OfflineEarn = seconds_for_recources * bank.BoostOfflineEarn;
            Debug.Log(Seconds_Offline);
            Debug.Log(bank.MaxOfflineTime);
            if (Seconds_Offline <= bank.MaxOfflineTime)
            {
                Debug.Log(1);
                CoinGain = OfflineEarn;
                RockGain = OfflineEarn;
                SoldiersGain = OfflineEarn / 100;
            }
            if (Seconds_Offline > bank.MaxOfflineTime)
            {
                Debug.Log(2);
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
    private void Update()
    {
    }
}