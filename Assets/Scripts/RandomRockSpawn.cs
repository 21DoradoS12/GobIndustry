using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRockSpawn : MonoBehaviour
{
    public GameObject RedRockPrefab;
    public GameObject BlueRockPrefab;
    public GameObject GreenRockPrefab;
    public GameObject YellowRockPrefab;
    public GameObject PinkRockPrefab;
    public long red = 0;
    public long blue = 0;
    public long green = 0;
    public long yellow = 0;
    public long pink = 0;
    public float time1;
    public float redwait = 0;
    public float bluewait = 0;
    public float greenwait = 0;
    public float yellowwait = 0;
    public float pinkwait = 0;
    public bool redOn = false;
    public bool blueOn = false;
    public bool greenOn = false;
    public bool yellowOn = false;
    public bool pinkOn = false;
    private BankResources bank;
    void Start()
    {
        bank = GameObject.FindObjectOfType<BankResources>();
        if (bank.FirstMining == false)
        {
            red = Random.Range(0, 2);
            blue = Random.Range(0, 2);
            green = Random.Range(0, 2);
            yellow = Random.Range(0, 2);
            pink = Random.Range(0, 2);
            bank.FirstMining = true;
        }
        if (red == 1)
        {
            Vector3 spawnPos = new Vector3(-1.53f, 2.17f, 0f);
            Instantiate(RedRockPrefab, spawnPos, Quaternion.identity);
        }
        if (blue == 1)
        {
            Vector3 spawnPos = new Vector3(1.27f, 2.17f, 0f);
            Instantiate(BlueRockPrefab, spawnPos, Quaternion.identity);
        }
        if (green == 1)
        {
            Vector3 spawnPos = new Vector3(-1.41f, -1.21f, 0f);
            Instantiate(GreenRockPrefab, spawnPos, Quaternion.identity);
        }
        if (yellow == 1)
        {
            Vector3 spawnPos = new Vector3(1.5f, -0.92f, 0f);
            Instantiate(YellowRockPrefab, spawnPos, Quaternion.identity);
        }
        if (pink == 1)
        {
            Vector3 spawnPos = new Vector3(-0.09f, 0.49f, 0f);
            Instantiate(PinkRockPrefab, spawnPos, Quaternion.identity);
        }
        if (red == 0)
        {
            redwait = Random.Range(30f / bank.DelayRockSpawn, 60f / bank.DelayRockSpawn);
        }
        if (blue == 0)
        {
            bluewait = Random.Range(45f / bank.DelayRockSpawn, 75f / bank.DelayRockSpawn);
        }
        if (green == 0)
        {
            greenwait = Random.Range(90f / bank.DelayRockSpawn, 120f / bank.DelayRockSpawn);
        }
        if (yellow == 0)
        {
            yellowwait = Random.Range(150f / bank.DelayRockSpawn, 180f / bank.DelayRockSpawn);
        }
        if (pink == 0)
        {
            pinkwait = Random.Range(240f / bank.DelayRockSpawn, 360f / bank.DelayRockSpawn);
        }
    }
    void FixedUpdate()
    {
        time1 += Time.deltaTime;
        if (time1 > redwait && red == 0 && redOn == false)
        {
            redOn = true;
            Vector3 spawnPos = new Vector3(-1.53f, 2.17f, 0f);
            Instantiate(RedRockPrefab, spawnPos, Quaternion.identity);
        }
        if (time1 > bluewait && blue == 0 && blueOn == false)
        {
            blueOn = true;
            Vector3 spawnPos = new Vector3(1.27f, 2.17f, 0f);
            Instantiate(BlueRockPrefab, spawnPos, Quaternion.identity);
        }
        if (time1 > greenwait && green == 0 && greenOn == false)
        {
            greenOn = true;
            Vector3 spawnPos = new Vector3(-1.41f, -1.21f, 0f);
            Instantiate(GreenRockPrefab, spawnPos, Quaternion.identity);
        }
        if (time1 > yellowwait && yellow == 0 && yellowOn == false)
        {
            yellowOn = true;
            Vector3 spawnPos = new Vector3(1.5f, -0.92f, 0f);
            Instantiate(YellowRockPrefab, spawnPos, Quaternion.identity);
        }
        if (time1 > pinkwait && pink == 0 && pinkOn == false)
        {
            pinkOn = true;
            Vector3 spawnPos = new Vector3(-0.09f, 0.49f, 0f);
            Instantiate(PinkRockPrefab, spawnPos, Quaternion.identity);
        }
    }
    void SpawnRedRock()
    {
        Vector3 spawnPos = new Vector3(-1.53f, 2.17f, 0f);
        Instantiate(RedRockPrefab, spawnPos, Quaternion.identity);
    }
    void SpawnBlueRock()
    {
        Vector3 spawnPos = new Vector3(1.27f, 2.17f, 0f);
        Instantiate(BlueRockPrefab, spawnPos, Quaternion.identity);
    }
    void SpawnGreenRock()
    {
        Vector3 spawnPos = new Vector3(-1.41f, -1.21f, 0f);
        Instantiate(GreenRockPrefab, spawnPos, Quaternion.identity);
    }
    void SpawnYellowRock()
    {
        Vector3 spawnPos = new Vector3(1.5f, -0.92f, 0f);
        Instantiate(YellowRockPrefab, spawnPos, Quaternion.identity);
    }
    void SpawnPinkRock()
    {
        Vector3 spawnPos = new Vector3(-0.09f, 0.49f, 0f);
        Instantiate(PinkRockPrefab, spawnPos, Quaternion.identity);
    }
}
