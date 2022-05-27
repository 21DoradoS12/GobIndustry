using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnCoin : MonoBehaviour
{
    public AudioClip audio;
    private BankResources bank;
    public AudioSource audioSource;
    public int odds;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
    }
    void FixedUpdate()
    {
        
    }
    public void MoneyAdd()
    {
        bank.MoneyToNewScene += bank.CoinApp;
        odds = Random.Range(0, 101);
    }
    public void MoneyMusic()
    {
        audioSource.PlayOneShot(audio);
    }
}
