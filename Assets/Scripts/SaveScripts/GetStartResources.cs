using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetStartResources : MonoBehaviour
{
    public GameObject GetKitMessage;
    public GameObject Blocker1;
    public GameObject Blocker2;
    public GameObject Blocker3;
    public GameObject Blocker4;
    public GameObject Image;
    private BankResources bank;
    void Start()
    {
        GetKitMessage.SetActive(false);
        bank = GameObject.FindObjectOfType<BankResources>();
        if (bank.getResources == true)
        {
            Destroy(GetKitMessage);
            Destroy(Image);
            Destroy(Blocker1);
            Destroy(Blocker2);
            Destroy(Blocker3);
            Destroy(Blocker4);
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
        Destroy(Blocker1);
        Destroy(Blocker2);
        Destroy(Blocker3);
        Destroy(Blocker4);
        bank.MoneyToNewScene += 100;
        bank.RockToNewScene += 100;
        bank.SoldiersToNewScene += 10;
        bank.SoldiersAppOdds += 100;
        bank.MultiplierValueRandomRocks += 1;
        bank.DelayRockSpawn += 1;
        bank.getResources = true;
        Destroy(Image);
        GetKitMessage.SetActive(true);
    }
    public void AcceptStartKit()
    {
        Destroy(GetKitMessage);
    }
}
