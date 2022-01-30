using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxesCollector : MonoBehaviour
{
    public GameObject GobCollector;
    private BankResources bank;
    void Start()
    {
        GobCollector.SetActive(false);
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void Update()
    {
        
        if (bank.TaxesTime >= 300)
        {
            GobCollector.SetActive(true);
        }
        if (bank.TaxesTime <= 300)
        {
            GobCollector.SetActive(false);
        }
    }
    public void LooseResurces()
    {
        float NewMoney = bank.MoneyToNewScene * 0.9f;
        bank.MoneyToNewScene = Mathf.RoundToInt(NewMoney);
        float NewRock = bank.RockToNewScene * 0.9f;
        bank.RockToNewScene = Mathf.RoundToInt(NewRock);
        float NewSoldiers = bank.SoldiersToNewScene * 0.9f;
        bank.SoldiersToNewScene = Mathf.RoundToInt(NewSoldiers);
        bank.TaxesTime = 0;
    }
    public void DeclineSuppose()
    {
        // Добавить булевую переменную, которая будет отвечать за то, идёт ли армия гобаф на тебя, если да, то время до прихода коллектора остаётся на 0, как только тебя ёбнут время пойдет...
        Debug.Log("Send Soldiers to village, after defeat they grab 50% all resources and GobCollector again arrived.");
    }
}
