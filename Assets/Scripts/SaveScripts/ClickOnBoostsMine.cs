using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnBoostsMine : MonoBehaviour
{

    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;
    public GameObject Image5;
    public GameObject Image6;
    public GameObject Image7;
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
    }
    void Update()
    {
        DeleteBoosts();
    }
    public void Boost1()
    {
        if (bank.RockToNewScene >= 75)
        {
            bank.RockToNewScene -= 75;
            bank.RockApp += 1;
            m1 = true;
            Destroy(Image1);
        }
    }
    public void Boost2()
    {
        if (bank.RockToNewScene >= 150)
        {
            bank.RockToNewScene -= 150;
            bank.RockApp += 3;
            m2 = true;
            Destroy(Image2);
        }
    }
    public void Boost3()
    {
        if (bank.RockToNewScene >= 300)
        {
            bank.RockToNewScene -= 300;
            bank.RockAppPassive += 1;
            m3 = true;
            Destroy(Image3);
        }
    }
    public void Boost4()
    {
        if (bank.RockToNewScene >= 600)
        {
            bank.RockToNewScene -= 600;
            bank.RockApp += 5;
            m4 = true;
            Destroy(Image4);
        }
    }
    public void Boost5()
    {
        if (bank.RockToNewScene >= 1000)
        {
            bank.RockToNewScene -= 1000;
            bank.RockAppPassive += 3;
            m5 = true;
            Destroy(Image5);
        }
    }
    public void Boost6()
    {
        if (bank.RockToNewScene >= 2000)
        {
            bank.RockToNewScene -= 2000;
            bank.MultiplierValueRandomRocks += 1;
            m6 = true;
            Destroy(Image6);
        }
    }
    public void Boost7()
    {
        if (bank.RockToNewScene >= 5000)
        {
            bank.RockToNewScene -= 5000;
            bank.DelayRockSpawn += 0.1f;
            m7 = true;
            Destroy(Image7);
        }
    }
    public void DeleteBoosts()
    {
        if(bank.boost1m == true)
        {
            Destroy(Image1);
        }
        if(bank.boost2m == true)
        {
            Destroy(Image2);
        }
        if(bank.boost3m == true)
        {
            Destroy(Image3);
        }
        if(bank.boost4m == true)
        {
            Destroy(Image4);
        }
        if(bank.boost5m == true)
        {
            Destroy(Image5);
        }
        if (bank.boost6m == true)
        {
            Destroy(Image6);
        }
    }
}
