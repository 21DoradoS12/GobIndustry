using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnBoosts : MonoBehaviour
{
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;
    public GameObject Image5;
    public GameObject Image6;
    public GameObject Image7;
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
    }
    void Update()
    {
        DestroyBoosts();
    }
    public void Boost1()
    {
        if (bank.MoneyToNewScene >= 50)
        {
            bank.MoneyToNewScene -= 50;
            bank.CoinApp += 1;
            b1 = true;
            Destroy(Image1);
        }
    }
    public void Boost2()
    {
        if (bank.MoneyToNewScene >= 100)
        {
            bank.MoneyToNewScene -= 100;
            bank.CoinAppPassive += 1;
            b2 = true;
            Destroy(Image2);
        }
    }
    public void Boost3()
    {
        if (bank.MoneyToNewScene >= 200)
        {
            bank.MoneyToNewScene -= 200;
            bank.CoinApp += 5;
            b3 = true;
            Destroy(Image3);
        }
    }
    public void Boost4()
    {
        if (bank.MoneyToNewScene >= 300)
        {
            bank.MoneyToNewScene -= 300;
            bank.CoinApp += 10;
            b4 = true;
            Destroy(Image4);
        }
    }
    public void Boost5()
    {
        if (bank.MoneyToNewScene >= 500)
        {
            bank.MoneyToNewScene -= 500;
            bank.CoinAppPassive += 2;
            b5 = true;
            Destroy(Image5);
        }
    }
    public void Boost6()
    {
        if (bank.MoneyToNewScene >= 5000)
        {
            bank.MoneyToNewScene -= 5000;
            bank.MaxOfflineTime += 600;
            b6 = true;
            Destroy(Image6);
        }
    }
    public void Boost7()
    {
        if (bank.MoneyToNewScene >= 7500)
        {
            bank.MoneyToNewScene -= 7500;
            bank.BoostOfflineEarn += 1;
            b7 = true;
            Destroy(Image7);
        }
    }
    public void DestroyBoosts()
    {
        if (bank.boost1b == true)
        {
            Destroy(Image1);
        }
        if (bank.boost2b == true)
        {
            Destroy(Image2);
        }
        if (bank.boost3b == true)
        {
            Destroy(Image3);
        }
        if (bank.boost4b == true)
        {
            Destroy(Image4);
        }
        if(bank.boost5b == true)
        {
            Destroy(Image5);
        }
        if(bank.boost6b == true)
        {
            Destroy(Image6);
        }
        if(bank.boost7b == true)
        {
            Destroy(Image7);
        }
    }
}
