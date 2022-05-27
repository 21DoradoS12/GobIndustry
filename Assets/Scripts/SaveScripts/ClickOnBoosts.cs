using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOnBoosts : MonoBehaviour
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
    public bool b1 = false;
    public bool b2 = false;
    public bool b3 = false;
    public bool b4 = false;
    public bool b5 = false;
    public bool b6 = false;
    public bool b7 = false;
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
        if (bank.MoneyToNewScene >= 50)
        {
            bank.MoneyToNewScene -= 50;
            bank.CoinApp += 1;
            bank.CountBonusesBank += 1;
            b1 = true;
            Boost1Sold.SetActive(true);
            Boost1Text.text = "Sold";
        }
    }
    public void Boost2()
    {
        if (bank.MoneyToNewScene >= 100)
        {
            bank.MoneyToNewScene -= 100;
            bank.CoinAppPassive += 1;
            bank.CountBonusesBank += 1;
            b2 = true;
            Boost2Sold.SetActive(true);
            Boost2Text.text = "Sold";
        }
    }
    public void Boost3()
    {
        if (bank.MoneyToNewScene >= 200)
        {
            bank.MoneyToNewScene -= 200;
            bank.CoinApp += 5;
            bank.CountBonusesBank += 1;
            b3 = true;
            Boost3Sold.SetActive(true);
            Boost3Text.text = "Sold";
        }
    }
    public void Boost4()
    {
        if (bank.MoneyToNewScene >= 300)
        {
            bank.MoneyToNewScene -= 300;
            bank.CoinApp += 10;
            bank.CountBonusesBank += 1;
            b4 = true;
            Boost4Sold.SetActive(true);
            Boost4Text.text = "Sold";
        }
    }
    public void Boost5()
    {
        if (bank.MoneyToNewScene >= 500)
        {
            bank.MoneyToNewScene -= 500;
            bank.CoinAppPassive += 2;
            bank.CountBonusesBank += 1;
            b5 = true;
            Boost5Sold.SetActive(true);
            Boost5Text.text = "Sold";
        }
    }
    public void Boost6()
    {
        if (bank.MoneyToNewScene >= 5000)
        {
            bank.MoneyToNewScene -= 5000;
            bank.MaxOfflineTime += 600;
            bank.CountBonusesBank += 1;
            b6 = true;
            Boost6Sold.SetActive(true);
            Boost6Text.text = "Sold";
        }
    }
    public void Boost7()
    {
        if (bank.MoneyToNewScene >= 7500)
        {
            bank.MoneyToNewScene -= 7500;
            bank.BoostOfflineEarn += 1;
            bank.CountBonusesBank += 1;
            b7 = true;
            Boost7Sold.SetActive(true);
            Boost7Text.text = "Sold";
        }
    }
    public void CorrectBoosts()
    {
        if (bank.boost1b == true)
        {
            Boost1Sold.SetActive(true);
            Boost1Text.text = "Sold";
        }
        if (bank.boost2b == true)
        {
            Boost2Sold.SetActive(true);
            Boost2Text.text = "Sold";
        }
        if (bank.boost3b == true)
        {
            Boost3Sold.SetActive(true);
            Boost3Text.text = "Sold";
        }
        if (bank.boost4b == true)
        {
            Boost4Sold.SetActive(true);
            Boost4Text.text = "Sold";
        }
        if(bank.boost5b == true)
        {
            Boost5Sold.SetActive(true);
            Boost5Text.text = "Sold";
        }
        if(bank.boost6b == true)
        {
            Boost6Sold.SetActive(true);
            Boost6Text.text = "Sold";
        }
        if(bank.boost7b == true)
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
