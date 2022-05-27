using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using UnityEngine.UI;
public class Chest : MonoBehaviour
{
    private BankResources bank;
    public GameObject Chest1;
    public GameObject Chest2;
    private ChestTime chestTime;
    public GameObject InformationMessage;
    public GameObject DecreaseTimeChestButton;
    public long CoinGet;
    public long RockGet;
    public long SoldiersGet;
    public Text CoinText;
    public Text RockText;
    public Text SoldiersText;
    public Text Count1Chest;
    public Text Count2Chest;
    public GameObject ChooseChestMenu;
    public GameObject ChooseChestButton;
    public GameObject Gob1Fragment;
    public GameObject Gob2Fragment;
    public GameObject Gob3Fragment;
    public long Gob1Chance;
    public long Gob2Chance;
    public long Gob3Chance;
    public Text Gob1Text;
    public Text Gob2Text;
    public Text Gob3Text;
    void Start()
    {
        ChooseChestButton.SetActive(true);
        ChooseChestMenu.SetActive(false);
        InformationMessage.SetActive(false);
        bank = GameObject.FindObjectOfType<BankResources>();
        chestTime = GameObject.FindObjectOfType<ChestTime>();
        if (bank.AvaliableChest1 == false && bank.AvaliableChest2 == false)
        {
            Chest1.SetActive(false);
            Chest2.SetActive(false);
            DecreaseTimeChestButton.SetActive(false);
        }
        if (bank.AvaliableChest1 == true)
        {
            Chest1.SetActive(true);
            Chest2.SetActive(false);
            DecreaseTimeChestButton.SetActive(true);
        }
        if (bank.AvaliableChest2 == true)
        {
            Chest1.SetActive(false);
            Chest2.SetActive(true);
            DecreaseTimeChestButton.SetActive(true);
        }
    }
    void FixedUpdate()
    {
        Count1Chest.text = bank.Chest1Count.ToString();
        Count2Chest.text = bank.Chest2Count.ToString();
        if (bank.AvaliableChest1 == true || bank.AvaliableChest2 == true)
        {
            ChooseChestMenu.SetActive(false);
            ChooseChestButton.SetActive(false);
        }
        if (chestTime.Chest1NewTime <= 0 || bank.Chest1Time <= 0)
        {
            DecreaseTimeChestButton.SetActive(false);
        }
    }
    public void GetChest_1()
    {
        if (bank.Chest1Count > 0)
        {
            if (bank.AvaliableChest1 == false)
            {
                chestTime.Chest1NewTime = 1800;
                bank.Chest1Time = 1800;
            }
            Chest1.SetActive(true);
            DecreaseTimeChestButton.SetActive(true);
            bank.AvaliableChest1 = true;
            chestTime.first_income = false;
            bank.Chest1Count -= 1;
        }
    }
    public void GetChest_2()
    {
        if (bank.Chest2Count > 0)
        {
            if (bank.AvaliableChest2 == false)
            {
                chestTime.Chest1NewTime = 4800;
                bank.Chest1Time = 4800;
            }
            Chest2.SetActive(true);
            DecreaseTimeChestButton.SetActive(true);
            bank.AvaliableChest2 = true;
            chestTime.first_income = false;
            Gob1Fragment.SetActive(false);
            Gob2Fragment.SetActive(false);
            Gob3Fragment.SetActive(false);
            bank.Chest2Count -= 1;
        }
    }
    public void OpenChest()
    {
        var ts = TimeSpan.FromSeconds(chestTime.Chest1NewTime);
        if (ts.Hours <= 0 && ts.Minutes <= 0 && ts.Seconds <= 0)
        {
            if (bank.AvaliableChest1 == true)
            {
                Chest1.SetActive(false);
                bank.AvaliableChest1 = false;
                CoinGet = UnityEngine.Random.Range(100, 500);
                bank.MoneyToNewScene += CoinGet;
                RockGet = UnityEngine.Random.Range(100, 500);
                bank.RockToNewScene += RockGet;
                SoldiersGet = UnityEngine.Random.Range(25, 75);
                Gob1Chance = UnityEngine.Random.Range(0, 11);
                if (Gob1Chance == 0)
                {
                    bank.Gob1Fragment += 1;
                    Gob1Text.text = 1.ToString();
                    Gob1Fragment.SetActive(true);
                }
                Gob2Chance = UnityEngine.Random.Range(0, 11);
                if (Gob2Chance == 0 && Gob1Chance != 0)
                {
                    bank.Gob2Fragment += 1;
                    Gob2Text.text = 1.ToString();
                    Gob2Fragment.SetActive(true);
                }
                Gob3Chance = UnityEngine.Random.Range(0, 11);
                if (Gob3Chance == 0 && Gob1Chance != 0 && Gob2Chance != 0)
                {
                    bank.Gob3Fragment += 1;
                    Gob2Text.text = 1.ToString();
                    Gob3Fragment.SetActive(true);
                }
                bank.SoldiersToNewScene += SoldiersGet;
            }
            if (bank.AvaliableChest2 == true)
            {
                Chest2.SetActive(false);
                bank.AvaliableChest2 = false;
                CoinGet = UnityEngine.Random.Range(500, 1500);
                bank.MoneyToNewScene += CoinGet;
                RockGet = UnityEngine.Random.Range(500, 1500);
                bank.RockToNewScene += RockGet;
                SoldiersGet = UnityEngine.Random.Range(150, 300);
                bank.SoldiersToNewScene += SoldiersGet;
                Gob1Chance = UnityEngine.Random.Range(0, 11);
                if (Gob1Chance == 0)
                {
                    bank.Gob1Fragment += 2;
                    Gob1Text.text = 2.ToString();
                    Gob1Fragment.SetActive(true);
                }
                Gob2Chance = UnityEngine.Random.Range(0, 11);
                if (Gob2Chance == 0 && Gob1Chance != 0)
                {
                    bank.Gob2Fragment += 2;
                    Gob2Text.text = 2.ToString();
                    Gob2Fragment.SetActive(true);
                }
                Gob3Chance = UnityEngine.Random.Range(0, 11);
                if (Gob3Chance == 0 && Gob1Chance != 0 && Gob2Chance != 0)
                {
                    bank.Gob3Fragment += 2;
                    Gob3Text.text = 2.ToString();
                    Gob3Fragment.SetActive(true);
                }
            }
            DecreaseTimeChestButton.SetActive(false);
            CoinText.text = CoinGet.ToString();
            RockText.text = RockGet.ToString();
            SoldiersText.text = SoldiersGet.ToString();
            InformationMessage.SetActive(true);
            ChooseChestButton.SetActive(true);
        }
        
    }
    public void MinusTimeChest()
    {
        if (bank.AvaliableChest1 == true)
        {
            Chest1.SetActive(true);
            bank.AvaliableChest1 = true;
            chestTime.first_income = false;
        }
        if (bank.AvaliableChest2 == true)
        {
            Chest2.SetActive(true);
            bank.AvaliableChest2 = true;
            chestTime.first_income = false;
        }
    }
    public void CloseInfoMessage()
    {
        InformationMessage.SetActive(false);
    }
    public void OpenChooseChestMenu()
    {
        ChooseChestMenu.SetActive(true);
    }
    public void CloseChooseChestMenu()
    {
        ChooseChestMenu.SetActive(false);
    }
}
