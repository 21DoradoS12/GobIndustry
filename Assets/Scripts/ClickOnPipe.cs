using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnPipe : MonoBehaviour
{
    public int odds;
    private BankResources bank;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void FixedUpdate()
    {
        
    }
    public void RecruitSoldiers()
    {
        odds = Random.Range(0, (int)bank.SoldiersAppOdds);
        if (odds == 0)
        {
            bank.SoldiersToNewScene += bank.SoldiersApp;
        }
    }
}
