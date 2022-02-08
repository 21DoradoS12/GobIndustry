using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetStartResources : MonoBehaviour
{
    public GameObject GetKitMessage;
    public GameObject Image;
    private BankResources bank;
    public GameObject Blockers;
    void Start()
    {
        GetKitMessage.SetActive(false);
        bank = GameObject.FindObjectOfType<BankResources>();
        if (bank.getResources == true)
        {
            Destroy(GetKitMessage);
            Destroy(Image);
            Destroy(Blockers);
        }
        if (bank.getResources == false)
        {
            Image.SetActive(true);
            Blockers.SetActive(true);
        }
    }
    void Update()
    {
        if (bank.TaxesTime >= 20 && GetKitMessage != null)
        {
            Destroy(GetKitMessage);
        }
    }
    public void GetStartPack()
    {
        bank.MoneyToNewScene += 100;
        bank.RockToNewScene += 100;
        bank.SoldiersToNewScene += 10;
        bank.SoldiersAppOdds += 100;
        bank.MultiplierValueRandomRocks += 1;
        bank.DelayRockSpawn += 1;
        bank.getResources = true;
        Destroy(Image);
        Destroy(Blockers);
        GetKitMessage.SetActive(true);
    }
    public void AcceptStartKit()
    {
        Destroy(GetKitMessage);
    }
}
