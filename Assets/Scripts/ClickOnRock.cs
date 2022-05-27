using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnRock : MonoBehaviour
{
    private UpdateRock updateRock;
    private BankResources bank;
    void Start()
    {
        updateRock = GameObject.FindObjectOfType<UpdateRock>();
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void FixedUpdate()
    {
        
    }
    public void RockAdd()
    {
        bank.RockToNewScene += bank.RockApp;
    }
}
