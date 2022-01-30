using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateSoldiers : MonoBehaviour
{
    public Text SoldiersText;
    private BankResources bank;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void Update()
    {
        SoldiersText.text = bank.SoldiersToNewScene.ToString();
    }
}
