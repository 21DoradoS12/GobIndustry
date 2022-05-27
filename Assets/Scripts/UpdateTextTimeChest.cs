using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTextTimeChest : MonoBehaviour
{
    public Text Hours1;
    public Text Minutes1;
    public Text Seconds1;
    public GameObject Timer;
    private ChestTime chestTime;
    void Start()
    {
        chestTime = GameObject.FindObjectOfType<ChestTime>();
        Timer.SetActive(false);
    }
    void FixedUpdate()
    {
        var ts = TimeSpan.FromSeconds(chestTime.Chest1NewTime);
        if (ts.TotalSeconds >= 1)
        {
            Timer.SetActive(true);
            Hours1.text = ts.Hours.ToString();
            Minutes1.text = ts.Minutes.ToString();
            Seconds1.text = ts.Seconds.ToString();
        }
        if (ts.TotalSeconds <= 0)
        {
            Timer.SetActive(false);
            Hours1.text = 0.ToString();
            Minutes1.text = 0.ToString();
            Seconds1.text = 0.ToString();
        }
    }
}
