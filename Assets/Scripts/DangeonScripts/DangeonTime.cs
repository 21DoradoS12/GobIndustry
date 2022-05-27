using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangeonTime : MonoBehaviour
{
    private CheckTime check;
    private BankResources bank;
    public bool first_gain;
    public float DungeonTime;
    void Start()
    {
        check = GameObject.FindObjectOfType<CheckTime>();
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void FixedUpdate()
    {
        if (first_gain == false)
        {
            DungeonTime = bank.DungeonTimeLeft;
            Debug.Log(DungeonTime);
            long time_left = check.seconds_for_recources;
            if (check.havedistorbDungeon == false)
            {
                Debug.Log(time_left);
                DungeonTime -= time_left;
                Debug.Log(DungeonTime);
                check.havedistorbDungeon = true;
            }
            first_gain = true;
        }
        if (DungeonTime != 0 && DungeonTime > 0)
        {
            DungeonTime -= Time.deltaTime;
            bank.DungeonTimeLeft = (long)DungeonTime;
        }
    }
}
