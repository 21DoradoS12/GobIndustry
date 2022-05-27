using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxesCollector : MonoBehaviour
{
    public GameObject GobCollector;
    private BankResources bank;
    public int GobAppear;
    void Start()
    {
        GobCollector.SetActive(false);
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void FixedUpdate()
    {
        
        if (bank.TaxesTime >= 300 && GobAppear == 0)
        {
            GobCollector.SetActive(true);
            GobAppear = 1;
        }
        if (bank.TaxesTime <= 300 && GobAppear == 1)
        {
            GobAppear = 0;
            GobCollector.SetActive(false);
        }
    }
}
