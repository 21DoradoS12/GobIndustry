using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
public class BankResources : MonoBehaviour
{
    public string path;
    public Save save = new Save();
    public GameObject NeedToSave;
    public GameObject GobMassanger;
    public bool getResources;
    private bool Sve = true;
    public int MoneyToNewScene;
    public int RockToNewScene;
    public int SoldiersToNewScene;
    public int CoinApp;
    public int RockApp;
    public int SoldiersApp;
    public int SoldiersAppOdds;
    public int CoinAppPassive;
    public int RockAppPassive;
    public int SoldiersAppPassive;
    public int MultiplierValueRandomRocks;
    public float DelayRockSpawn;
    public bool boost1b;
    public bool boost2b;
    public bool boost3b;
    public bool boost4b;
    public bool boost5b;
    public bool boost6b;
    public bool boost7b;
    public bool boost1m;
    public bool boost2m;
    public bool boost3m;
    public bool boost4m;
    public bool boost5m;
    public bool boost6m;
    public bool boost7m;
    public bool boost1s;
    public bool boost2s;
    public bool boost3s;
    public bool boost4s;
    public bool boost5s;
    public bool FirstMining;
    public float TaxesTime;
    public string exitTime;
    public int MaxOfflineTime;
    public int BoostOfflineEarn;
    public int Chest1Time;
    public bool AvaliableChest1;
    public bool AvaliableChest2;
    public int DungeonTimeLeft;
    public bool DungeonOn1;
    public bool DungeonOn2;
    public int Chest1Count;
    public int Chest2Count;
    private EnternetCheck enternet;
    void Start()
    {

#if UNITY_ANDROID && !UNITY_EDITOR
        path = Path.Combine(Application.persistentDataPath, "Save.json");
#else
        path = Path.Combine(Application.dataPath, "Save.json");
#endif
        if (File.Exists(path))
        {
            enternet = GameObject.FindObjectOfType<EnternetCheck>();
            save = JsonUtility.FromJson<Save>(File.ReadAllText(path));
            MoneyToNewScene = save.coin;
            RockToNewScene = save.rock;
            SoldiersToNewScene = save.soldiers;
            CoinApp = save.RaiseCoin;
            CoinAppPassive = save.RaiseCoinPassive;
            RockApp = save.RaiseRock;
            RockAppPassive = save.RaiseRockPassive;
            SoldiersApp = save.RaiseSoldiers;
            SoldiersAppPassive = save.RaiseSoldiersPassive;
            SoldiersAppOdds = save.SoldiersOdds;
            MultiplierValueRandomRocks = save.MultiplierRandomRockValue;
            DelayRockSpawn = save.DelaySpawnRandomRocks;
            boost1b = save.Boost1Bank;
            boost2b = save.Boost2Bank;
            boost3b = save.Boost3Bank;
            boost4b = save.Boost4Bank;
            boost5b = save.Boost5Bank;
            boost6b = save.Boost6Bank;
            boost7b = save.Boost7Bank;
            boost1m = save.Boost1Mine;
            boost2m = save.Boost2Mine;
            boost3m = save.Boost3Mine;
            boost4m = save.Boost4Mine;
            boost5m = save.Boost5Mine;
            boost6m = save.Boost6Mine;
            boost7m = save.Boost7Mine;
            boost1s = save.Boost1Soldiers;
            boost2s = save.Boost2Soldiers;
            boost3s = save.Boost3Soldiers;
            boost4s = save.Boost4Soldiers;
            boost5s = save.Boost5Soldiers;
            getResources = save.GetStartResources;
            FirstMining = save.FirstMining;
            TaxesTime = save.TaxesTime;
            if (enternet.InternetOff == false)
                exitTime = save.exitTime;
            MaxOfflineTime = save.MaxOfflineTime;
            BoostOfflineEarn = save.BoostOfflineEarn;
            Chest1Time = save.Chest1Time;
            DungeonTimeLeft = save.DungeonTimeLeft;
            DungeonOn1 = save.DungeonOn1;
            DungeonOn2 = save.DungeonOn2;
            AvaliableChest1 = save.AvaliableChest1;
            AvaliableChest2 = save.AvaliableChest2;
            Chest1Count = save.Chest1Count;
            Chest2Count = save.Chest2Count;
        }
        DontDestroyOnLoad(NeedToSave);
        DontDestroyOnLoad(GobMassanger);
        if (MaxOfflineTime == 0)
            MaxOfflineTime = 1800;
        if (BoostOfflineEarn == 0)
            BoostOfflineEarn = 1;
    }
    void Update()
    {
        if (getResources == true)
            TaxesTime += Time.deltaTime;
    }
}
