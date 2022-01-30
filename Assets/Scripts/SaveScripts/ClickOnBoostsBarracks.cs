using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnBoostsBarracks : MonoBehaviour
{
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;
    public GameObject Image5;
    public bool s1 = false;
    public bool s2 = false;
    public bool s3 = false;
    public bool s4 = false;
    public bool s5 = false;
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
        if (bank.MoneyToNewScene >= 50 && bank.RockToNewScene >= 50)
        {
            bank.MoneyToNewScene -= 50;
            bank.RockToNewScene -= 50;
            bank.SoldiersApp += 1;
            s1 = true;
            Destroy(Image1);
        }
    }
    public void Boost2()
    {
        if (bank.MoneyToNewScene >= 100 && bank.RockToNewScene >= 100)
        {
            bank.MoneyToNewScene -= 100;
            bank.RockToNewScene -= 100;
            bank.SoldiersApp += 2;
            s2 = true;
            Destroy(Image2);
        }
    }
    public void Boost3()
    {
        if (bank.MoneyToNewScene >= 200 && bank.RockToNewScene >= 200)
        {
            bank.MoneyToNewScene -= 200;
            bank.RockToNewScene -= 200;
            bank.SoldiersAppOdds -= 10;
            s3 = true;
            Destroy(Image3);
        }
    }
    public void Boost4()
    {
        if (bank.MoneyToNewScene >= 300 && bank.RockToNewScene >= 300)
        {
            bank.MoneyToNewScene -= 300;
            bank.RockToNewScene -= 300;
            bank.SoldiersApp += 5;
            s4 = true;
            Destroy(Image4);
        }
    }
    public void Boost5()
    {
        if(bank.MoneyToNewScene >= 500 && bank.RockToNewScene >= 500)
        {
            bank.MoneyToNewScene -= 500;
            bank.RockToNewScene -= 500;
            bank.SoldiersAppPassive += 1;
            s5 = true;
            Destroy(Image5);
        }
    }
    public void DestroyBoosts()
    {
        if (bank.boost1s == true)
        {
            Destroy(Image1);
        }
        if (bank.boost2s == true)
        {
            Destroy(Image2);
        }
        if (bank.boost3s == true)
        {
            Destroy(Image3);
        }
        if (bank.boost4s == true)
        {
            Destroy(Image4);
        }
        if (bank.boost5s == true)
        {
            Destroy(Image5);
        }
    }
}
