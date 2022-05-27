using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOnBoostsMine : MonoBehaviour
{

    public GameObject Boost1Sold;
    public GameObject Boost2Sold;
    public GameObject Boost3Sold;
    public GameObject Boost4Sold;
    public GameObject Boost5Sold;
    public GameObject Boost6Sold;
    public GameObject Boost7Sold;
    public Text Boost1Text;
    public Text Boost2Text;
    public Text Boost3Text;
    public Text Boost4Text;
    public Text Boost5Text;
    public Text Boost6Text;
    public Text Boost7Text;
    public bool m1 = false;
    public bool m2 = false;
    public bool m3 = false;
    public bool m4 = false;
    public bool m5 = false;
    public bool m6 = false;
    public bool m7 = false;
    private BankResources bank;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
        SoldBoostsFalse();
    }
    void FixedUpdate()
    {
        CorrectBoosts();
    }
    public void Boost1()
    {
        if (bank.RockToNewScene >= 75)
        {
            bank.RockToNewScene -= 75;
            bank.RockApp += 1;
            bank.CountBonusesMine += 1;
            m1 = true;
            Boost1Sold.SetActive(true);
            Boost1Text.text = "Sold";
        }
    }
    public void Boost2()
    {
        if (bank.RockToNewScene >= 150)
        {
            bank.RockToNewScene -= 150;
            bank.RockApp += 3;
            bank.CountBonusesMine += 1;
            m2 = true;
            Boost2Sold.SetActive(true);
            Boost2Text.text = "Sold";
        }
    }
    public void Boost3()
    {
        if (bank.RockToNewScene >= 300)
        {
            bank.RockToNewScene -= 300;
            bank.RockAppPassive += 1;
            bank.CountBonusesMine += 1;
            m3 = true;
            Boost3Sold.SetActive(true);
            Boost3Text.text = "Sold";
        }
    }
    public void Boost4()
    {
        if (bank.RockToNewScene >= 600)
        {
            bank.RockToNewScene -= 600;
            bank.RockApp += 5;
            bank.CountBonusesMine += 1;
            m4 = true;
            Boost4Sold.SetActive(true);
            Boost4Text.text = "Sold";
        }
    }
    public void Boost5()
    {
        if (bank.RockToNewScene >= 1000)
        {
            bank.RockToNewScene -= 1000;
            bank.RockAppPassive += 3;
            bank.CountBonusesMine += 1;
            m5 = true;
            Boost5Sold.SetActive(true);
            Boost5Text.text = "Sold";
        }
    }
    public void Boost6()
    {
        if (bank.RockToNewScene >= 2000)
        {
            bank.RockToNewScene -= 2000;
            bank.MultiplierValueRandomRocks += 1;
            bank.CountBonusesMine += 1;
            m6 = true;
            Boost6Sold.SetActive(true);
            Boost6Text.text = "Sold";
        }
    }
    public void Boost7()
    {
        if (bank.RockToNewScene >= 5000)
        {
            bank.RockToNewScene -= 5000;
            bank.DelayRockSpawn += 0.1f;
            bank.CountBonusesMine += 1;
            m7 = true;
            Boost7Sold.SetActive(true);
            Boost7Text.text = "Sold";
        }
    }
    public void CorrectBoosts()
    {
        if(bank.boost1m == true)
        {
            Boost1Sold.SetActive(true);
            Boost1Text.text = "Sold";
        }
        if(bank.boost2m == true)
        {
            Boost2Sold.SetActive(true);
            Boost2Text.text = "Sold";
        }
        if(bank.boost3m == true)
        {
            Boost3Sold.SetActive(true);
            Boost3Text.text = "Sold";
        }
        if(bank.boost4m == true)
        {
            Boost4Sold.SetActive(true);
            Boost4Text.text = "Sold";
        }
        if(bank.boost5m == true)
        {
            Boost5Sold.SetActive(true);
            Boost5Text.text = "Sold";
        }
        if (bank.boost6m == true)
        {
            Boost6Sold.SetActive(true);
            Boost6Text.text = "Sold";
        }
        if (bank.boost7m == true)
        {
            Boost7Sold.SetActive(true);
            Boost7Text.text = "Sold";
        }
    }
    public void SoldBoostsFalse()
    {
        Boost1Sold.SetActive(false);
        Boost2Sold.SetActive(false);
        Boost3Sold.SetActive(false);
        Boost4Sold.SetActive(false);
        Boost5Sold.SetActive(false);
        Boost6Sold.SetActive(false);
        Boost7Sold.SetActive(false);
    }
}
