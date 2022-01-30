using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System;

public class ChooseDungeon : MonoBehaviour
{
    public Sprite MainGround;
    public Sprite Dun_1;
    public Sprite Dun_2;
    public GameObject actionHero;
    public GameObject ListOfDungeons;
    public GameObject getReward;
    public GameObject Timer;
    public Image getRecources;
    private BankResources bank;
    private DangeonTime dungeon;
    public Text Hours1;
    public Text Minutes1;
    public Text Seconds1;
    public Text CoinGet;
    public Text RockGet;
    public Text SoldiersGet;
    public int CoinApp;
    public int RockApp;
    public int SoldiersApp;
    public GameObject InforamtionTable;
    public GameObject BackGroundDungeon;
    public int ChanceGetChest1;
    public int ChanceGetChest2;
    public Text CountGetChest1;
    public Text CountGetChest2;
    void Start()
    {
        InforamtionTable.SetActive(false);
        bank = GameObject.FindObjectOfType<BankResources>();
        dungeon = GameObject.FindObjectOfType<DangeonTime>();
        if (bank.DungeonOn1 == false && bank.DungeonOn2 == false)
        {
            actionHero.SetActive(false);
            getReward.SetActive(false);
            Timer.SetActive(false);
            BackGroundDungeon.GetComponent<SpriteRenderer>().sprite = MainGround;
            ListOfDungeons.SetActive(true);
        }
        if (bank.DungeonOn1 == true || bank.DungeonOn2 == true)
        {
            if (bank.DungeonOn1 == true)
                BackGroundDungeon.GetComponent<SpriteRenderer>().sprite = Dun_1;
            if (bank.DungeonOn2 == true)
                BackGroundDungeon.GetComponent<SpriteRenderer>().sprite = Dun_2;
            actionHero.SetActive(true);
            getReward.SetActive(true);
            Timer.SetActive(true);
            ListOfDungeons.SetActive(false);
        }
    }
    void Update()
    {
        if (dungeon.DungeonTime <= 0)
        {
            actionHero.SetActive(false);
            BackGroundDungeon.GetComponent<SpriteRenderer>().sprite = MainGround;
            getRecources.color = Color.white;
        }
        if (dungeon.DungeonTime > 0)
            getRecources.color = Color.grey;
        var ts = TimeSpan.FromSeconds(dungeon.DungeonTime);
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
    public void Dungeon_1()
    {
        bank.DungeonTimeLeft = 1800;
        dungeon.DungeonTime = 1800;
        actionHero.SetActive(true);
        getReward.SetActive(true);
        Timer.SetActive(true);
        BackGroundDungeon.GetComponent<SpriteRenderer>().sprite = Dun_1;
        ListOfDungeons.SetActive(false);
        bank.DungeonOn1 = true;
    }
    public void Dungeon_2()
    {
        bank.DungeonTimeLeft = 3600;
        dungeon.DungeonTime = 3600;
        actionHero.SetActive(true);
        getReward.SetActive(true);
        Timer.SetActive(true);
        BackGroundDungeon.GetComponent<SpriteRenderer>().sprite = Dun_2;
        ListOfDungeons.SetActive(false);
        bank.DungeonOn2 = true;
    }
    public void GetReward()
    {
        if (dungeon.DungeonTime <= 0)
        {
            actionHero.SetActive(false);
            getReward.SetActive(false);
            Timer.SetActive(false);
            BackGroundDungeon.GetComponent<SpriteRenderer>().sprite = MainGround;
            if (bank.DungeonOn1 == true)
            {
                CoinApp = UnityEngine.Random.Range(100, 500);
                bank.MoneyToNewScene += CoinApp;
                CoinGet.text = CoinApp.ToString();
                RockApp = UnityEngine.Random.Range(100, 500);
                bank.RockToNewScene += RockApp;
                RockGet.text = RockApp.ToString();
                SoldiersApp = UnityEngine.Random.Range(25, 75);
                bank.SoldiersToNewScene += SoldiersApp;
                SoldiersGet.text = SoldiersApp.ToString();
                CheckWin1();
                CheckWin2();
                InforamtionTable.SetActive(true);
                bank.DungeonOn1 = false;
            }
            if (bank.DungeonOn2 == true)
            {
                CoinApp = UnityEngine.Random.Range(500, 1000);
                bank.MoneyToNewScene += CoinApp;
                CoinGet.text = CoinApp.ToString();
                RockApp = UnityEngine.Random.Range(500, 1000);
                bank.RockToNewScene += RockApp;
                RockGet.text = RockApp.ToString();
                SoldiersApp = UnityEngine.Random.Range(75, 150);
                bank.SoldiersToNewScene += SoldiersApp;
                SoldiersGet.text = SoldiersApp.ToString();
                CheckWin1();
                CheckWin2();
                InforamtionTable.SetActive(true);
                bank.DungeonOn2 = false;
            }
        }
    }
    public void CloseTable()
    {
        InforamtionTable.SetActive(false);
        ListOfDungeons.SetActive(true);
    }
    public void CheckWin1()
    {
        if (bank.DungeonOn1 == true)
        {
            ChanceGetChest1 = UnityEngine.Random.Range(1, 11);
            if (ChanceGetChest1 == 1)
            {
                CountGetChest1.text = 1.ToString();
                bank.Chest1Count += 1;
            }
            else
            {
                CountGetChest1.text = 0.ToString();
            }
        }
        if (bank.DungeonOn2 == true)
        {
            ChanceGetChest1 = UnityEngine.Random.Range(1, 6);
            if (ChanceGetChest1 == 1)
            {
                CountGetChest1.text = 1.ToString();
                bank.Chest1Count += 1;
            }
            else
            {
                CountGetChest1.text = 0.ToString();
            }
        }
    }
    public void CheckWin2()
    {
        if (bank.DungeonOn1 == true)
        {
            ChanceGetChest2 = UnityEngine.Random.Range(1, 26);
            if (ChanceGetChest2 == 1)
            {
                CountGetChest2.text = 1.ToString();
                bank.Chest2Count += 1;
            }
            else
            {
                CountGetChest2.text = 0.ToString();
            }
        }
        if (bank.DungeonOn2 == true)
        {
            ChanceGetChest2 = UnityEngine.Random.Range(1, 14);
            if (ChanceGetChest2 == 1)
            {
                CountGetChest2.text = 1.ToString();
                bank.Chest2Count += 1;
            }
            else
            {
                CountGetChest2.text = 0.ToString();
            }
        }
    }
}
