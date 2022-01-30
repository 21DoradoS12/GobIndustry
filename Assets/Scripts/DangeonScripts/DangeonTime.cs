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
    void Update()
    {
        if (first_gain == false)
        {
            DungeonTime = bank.DungeonTimeLeft;
            int time_left = check.seconds_for_recources;
            if (check.havedistorbDungeon == false)
            {
                DungeonTime -= time_left;
                check.havedistorbDungeon = true;
            }
            first_gain = true;
        }
        if (DungeonTime != 0 && DungeonTime > 0)
        {
            DungeonTime -= Time.deltaTime;
            bank.DungeonTimeLeft = (int)DungeonTime;
        }
    }
}
