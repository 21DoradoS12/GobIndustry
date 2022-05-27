using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRockInput : MonoBehaviour
{
    private long redvalue = 5;
    private long bluevalue = 10;
    private long greenvalue = 20;
    private long yellowvalue = 40;
    private long pinkvalue = 75;
    private UpdateRock updateRock;
    private RandomRockSpawn random;
    private float redtime = 0;
    private float bluetime = 0;
    private float greentime = 0;
    private float yellowtime = 0;
    private float pinktime = 0;
    private BankResources bank;
    public Save save = new Save();
    public bool redOn = false;
    public bool blueOn = false;
    public bool greenOn = false;
    public bool yellowOn = false;
    public bool pinkOn = false;
    void Start()
    {
        updateRock = GameObject.FindObjectOfType<UpdateRock>();
        random = GameObject.FindObjectOfType<RandomRockSpawn>();
        bank = GameObject.FindObjectOfType<BankResources>();
        redvalue = redvalue * bank.MultiplierValueRandomRocks;
        bluevalue = bluevalue * bank.MultiplierValueRandomRocks;
        greenvalue = greenvalue * bank.MultiplierValueRandomRocks;
        yellowvalue = yellowvalue * bank.MultiplierValueRandomRocks;
        pinkvalue = pinkvalue * bank.MultiplierValueRandomRocks;
    }
    void FixedUpdate()
    {
    }
    void OnMouseDown()
    {
        if (this.gameObject.tag == "RedRock")
        {
            redOn = true;
            bank.RockToNewScene += redvalue;
            redtime = Random.Range(30f / bank.DelayRockSpawn, 60f / bank.DelayRockSpawn);
            random.Invoke("SpawnRedRock", redtime);
            Destroy(this.gameObject);
        }
        if (this.gameObject.tag == "BlueRock")
        {
            blueOn = true;
            bank.RockToNewScene += bluevalue;
            bluetime = Random.Range(45f / bank.DelayRockSpawn, 75f / bank.DelayRockSpawn);
            random.Invoke("SpawnBlueRock", bluetime);
            Destroy(this.gameObject);
        }
        if (this.gameObject.tag == "GreenRock")
        {
            greenOn = true;
            bank.RockToNewScene += greenvalue;
            greentime = Random.Range(90f / bank.DelayRockSpawn, 120f / bank.DelayRockSpawn);
            random.Invoke("SpawnGreenRock", greentime);
            Destroy(this.gameObject);
        }
        if (this.gameObject.tag == "YellowRock")
        {
            yellowOn = true;
            bank.RockToNewScene += yellowvalue;
            yellowtime = Random.Range(150f / bank.DelayRockSpawn, 180f / bank.DelayRockSpawn);
            random.Invoke("SpawnYellowRock", yellowtime);
            Destroy(this.gameObject);
        }
        if (this.gameObject.tag == "PinkRock")
        {
            pinkOn = true;
            bank.RockToNewScene += pinkvalue;
            pinktime = Random.Range(240f / bank.DelayRockSpawn, 360f / bank.DelayRockSpawn);
            random.Invoke("SpawnPinkRock", pinktime);
            Destroy(this.gameObject);
        }
    }
}
