using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    void Start()
    {
        check = GameObject.FindObjectOfType<CheckTime>();
        OfflineTable.SetActive(true);
    }
    void Update()
    {
        if (check.Total_Offline_Time.Seconds > 0 && ShowTable == false)
        {
            Days.text = check.Total_Offline_Time.Days.ToString();
            Hours.text = check.Total_Offline_Time.Hours.ToString();
            Minutes.text = check.Total_Offline_Time.Minutes.ToString();
            Seconds.text = check.Total_Offline_Time.Seconds.ToString();
            Coins.text = check.OfflineEarn.ToString();
            Rocks.text = check.OfflineEarn.ToString();
            Man_s = check.OfflineEarn / 100;
            Mans.text = Man_s.ToString();
            ShowTable = true;
        }
    }
    public void CloseOfflineTable()
    {
        OfflineTable.SetActive(false);
    }
}
