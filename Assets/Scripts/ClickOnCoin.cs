using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnCoin : MonoBehaviour
{
    public AudioClip audio;
    private BankResources bank;
    public AudioSource audioSource;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void Update()
    {
        
    }
    public void MoneyAdd()
    {
        bank.MoneyToNewScene += bank.CoinApp;
    }
    public void MoneyMusic()
    {
        audioSource.PlayOneShot(audio);
    }
}
