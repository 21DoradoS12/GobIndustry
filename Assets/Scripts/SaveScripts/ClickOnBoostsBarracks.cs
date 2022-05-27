using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickOnBoostsBarracks : MonoBehaviour
{
    public GameObject Boost1Sold;
    public GameObject Boost2Sold;
    public GameObject Boost3Sold;
    public GameObject Boost4Sold;
    public GameObject Boost5Sold;
    public Text Boost1Text;
    public Text Boost2Text;
    public Text Boost3Text;
    public Text Boost4Text;
    public Text Boost5Text;
    public bool s1 = false;
    public bool s2 = false;
    public bool s3 = false;
    public bool s4 = false;
    public bool s5 = false;
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
        if (bank.MoneyToNewScene >= 50 && bank.RockToNewScene >= 50)
        {
            bank.MoneyToNewScene -= 50;
            bank.RockToNewScene -= 50;
            bank.SoldiersApp += 1;
            bank.CountBonusesSoldiers += 1;
            s1 = true;
            Boost1Sold.SetActive(true);
            Boost1Text.text = "Sold";
        }
    }
    public void Boost2()
    {
        if (bank.MoneyToNewScene >= 100 && bank.RockToNewScene >= 100)
        {
            bank.MoneyToNewScene -= 100;
            bank.RockToNewScene -= 100;
            bank.SoldiersApp += 2;
            bank.CountBonusesSoldiers += 1;
            s2 = true;
            Boost2Sold.SetActive(true);
            Boost2Text.text = "Sold";
        }
    }
    public void Boost3()
    {
        if (bank.MoneyToNewScene >= 200 && bank.RockToNewScene >= 200)
        {
            bank.MoneyToNewScene -= 200;
            bank.RockToNewScene -= 200;
            bank.SoldiersAppOdds -= 10;
            bank.CountBonusesSoldiers += 1;
            s3 = true;
            Boost3Sold.SetActive(true);
            Boost3Text.text = "Sold";
        }
    }
    public void Boost4()
    {
        if (bank.MoneyToNewScene >= 300 && bank.RockToNewScene >= 300)
        {
            bank.MoneyToNewScene -= 300;
            bank.RockToNewScene -= 300;
            bank.SoldiersApp += 5;
            bank.CountBonusesSoldiers += 1;
            s4 = true;
            Boost4Sold.SetActive(true);
            Boost4Text.text = "Sold";
        }
    }
    public void Boost5()
    {
        if(bank.MoneyToNewScene >= 500 && bank.RockToNewScene >= 500)
        {
            bank.MoneyToNewScene -= 500;
            bank.RockToNewScene -= 500;
            bank.SoldiersAppPassive += 1;
            bank.CountBonusesSoldiers += 1;
            s5 = true;
            Boost5Sold.SetActive(true);
            Boost5Text.text = "Sold";
        }
    }
    public void CorrectBoosts()
    {
        if (bank.boost1s == true)
        {
            Boost1Sold.SetActive(true);
            Boost1Text.text = "Sold";
        }
        if (bank.boost2s == true)
        {
            Boost2Sold.SetActive(true);
            Boost2Text.text = "Sold";
        }
        if (bank.boost3s == true)
        {
            Boost3Sold.SetActive(true);
            Boost3Text.text = "Sold";
        }
        if (bank.boost4s == true)
        {
            Boost4Sold.SetActive(true);
            Boost4Text.text = "Sold";
        }
        if (bank.boost5s == true)
        {
            Boost5Sold.SetActive(true);
            Boost5Text.text = "Sold";
        }
    }
    public void SoldBoostsFalse()
    {
        Boost1Sold.SetActive(false);
        Boost2Sold.SetActive(false);
        Boost3Sold.SetActive(false);
        Boost4Sold.SetActive(false);
        Boost5Sold.SetActive(false);
    }
}
