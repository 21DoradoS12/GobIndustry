using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;
public class OfflineGameInformation : MonoBehaviour
{
    public GameObject OfflineTable;
    public Text Days;
    public Text Hours;
    public Text Minutes;
    public Text Seconds;
    public Text Coins;
    public Text Rocks;
    public Text Mans;
    private CheckTime check;
    public bool ShowTable = false;
    public int Man_s;
    private EnternetCheck enternet;
    private BankResources bank;
    private SceneLoad scene;
    void Start()
    {
        scene = GameObject.FindObjectOfType<SceneLoad>();
        bank = GameObject.FindObjectOfType<BankResources>();
        enternet = GameObject.FindObjectOfType<EnternetCheck>();
        check = GameObject.FindObjectOfType<CheckTime>();
        Debug.Log(scene.FirstExit);
        if (ShowTable == false && enternet.GetInformation == false && bank.getResources == true && scene.FirstExit == true)
        {
            OfflineTable.SetActive(true);
            Debug.Log(bank.exitTime);
        }
    }
    void Update()
    {
        if (check.Total_Offline_Time.Seconds > 0 && ShowTable == false && enternet.GetInformation == false)
        {
            Days.text = check.Total_Offline_Time.Days.ToString();
            Hours.text = check.Total_Offline_Time.Hours.ToString();
            Minutes.text = check.Total_Offline_Time.Minutes.ToString();
            Seconds.text = check.Total_Offline_Time.Seconds.ToString();
            Coins.text = check.CoinGain.ToString();
            Rocks.text = check.RockGain.ToString();
            Man_s = check.SoldiersGain;
            Mans.text = Man_s.ToString();
            ShowTable = true;
        }
    }
    public void CloseOfflineTable()
    {
        OfflineTable.SetActive(false);
    }
}
