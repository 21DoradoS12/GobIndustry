using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTextTimeChest : MonoBehaviour
{
    public Text Hours1;
    public Text Minutes1;
    public Text Seconds1;
    private ChestTime chestTime;
    void Start()
    {
        chestTime = GameObject.FindObjectOfType<ChestTime>();
    }
    void Update()
    {
        var ts = TimeSpan.FromSeconds(chestTime.Chest1NewTime);
        if (ts.Seconds >= 0)
        {
            Hours1.text = ts.Hours.ToString();
            Minutes1.text = ts.Minutes.ToString();
            Seconds1.text = ts.Seconds.ToString();
        }
        else
        {
            Hours1.text = 0.ToString();
            Minutes1.text = 0.ToString();
            Seconds1.text = 0.ToString();
        }
    }
}
