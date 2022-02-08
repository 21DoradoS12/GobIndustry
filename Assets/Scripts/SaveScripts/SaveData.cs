using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
public class SaveData : MonoBehaviour
{
    public Save save = new Save();
    public string path;
    private UpdateCoin updateCoin;
    private UpdateRock updateRock;
    private PassiveIncome passive;
    private BankResources bank;
    private bool a = false;
    private EnternetCheck enternet;
    private void Start()
    {
        enternet = GameObject.FindObjectOfType<EnternetCheck>();
        passive = GameObject.FindObjectOfType<PassiveIncome>();
        bank = GameObject.FindObjectOfType<BankResources>();
        updateCoin = GameObject.FindObjectOfType<UpdateCoin>();
        updateRock = GameObject.FindObjectOfType<UpdateRock>();
#if UNITY_ANDROID && !UNITY_EDITOR
        path = Path.Combine(Application.persistentDataPath, "Save.json");
#else
        path = Path.Combine(Application.dataPath, "Save.json");
#endif
        if (File.Exists(path))
        {
            save = JsonUtility.FromJson<Save>(File.ReadAllText(path));
        }
    }
#if UNITY_ANDROID && !UNITY_EDITOR
    private void OnApplicationPause(bool pause)
    {
        if (pause) File.WriteAllText(path, JsonUtility.ToJson(sv));
    }
#endif
    private void OnApplicationQuit()
    {
        Scene now_scene = SceneManager.GetActiveScene();
        if (now_scene.name != "MainMenu")
            save.FirstExit = true;
        save.coin = bank.MoneyToNewScene;
        save.rock = bank.RockToNewScene;
        save.soldiers = bank.SoldiersToNewScene;
        save.RaiseCoin = bank.CoinApp;
        save.RaiseCoinPassive = bank.CoinAppPassive;
        save.RaiseRock = bank.RockApp;
        save.RaiseRockPassive = bank.RockAppPassive;
        save.RaiseSoldiers = bank.SoldiersApp;
        save.RaiseSoldiersPassive = bank.SoldiersAppPassive;
        save.SoldiersOdds = bank.SoldiersAppOdds;
        save.DelaySpawnRandomRocks = bank.DelayRockSpawn;
        save.MultiplierRandomRockValue = bank.MultiplierValueRandomRocks;
        save.Boost1Bank = bank.boost1b;
        save.Boost2Bank = bank.boost2b;
        save.Boost3Bank = bank.boost3b;
        save.Boost4Bank = bank.boost4b;
        save.Boost5Bank = bank.boost5b;
        save.Boost6Bank = bank.boost6b;
        save.Boost7Bank = bank.boost7b;
        save.Boost1Mine = bank.boost1m;
        save.Boost2Mine = bank.boost2m;
        save.Boost3Mine = bank.boost3m;
        save.Boost4Mine = bank.boost4m;
        save.Boost5Mine = bank.boost5m;
        save.Boost6Mine = bank.boost6m;
        save.Boost7Mine = bank.boost7m;
        save.Boost1Soldiers = bank.boost1s;
        save.Boost2Soldiers = bank.boost2s;
        save.Boost3Soldiers = bank.boost3s;
        save.Boost4Soldiers = bank.boost4s;
        save.Boost5Soldiers = bank.boost5s;
        save.GetStartResources = bank.getResources;
        save.FirstMining = bank.FirstMining;
        save.TaxesTime = bank.TaxesTime;
        if (enternet.InternetOff == false)
            save.exitTime = bank.exitTime;
        save.MaxOfflineTime = bank.MaxOfflineTime;
        save.BoostOfflineEarn = bank.BoostOfflineEarn;
        save.Chest1Time = bank.Chest1Time;
        save.AvaliableChest1 = bank.AvaliableChest1;
        save.AvaliableChest2 = bank.AvaliableChest2;
        save.DungeonTimeLeft = bank.DungeonTimeLeft;
        save.DungeonOn1 = bank.DungeonOn1;
        save.DungeonOn2 = bank.DungeonOn2;
        save.Chest1Count = bank.Chest1Count;
        save.Chest2Count = bank.Chest2Count;
        File.WriteAllText(path, JsonUtility.ToJson(save));
    }
}

[Serializable]
public class Save
{
    public int coin;
    public int rock;
    public int soldiers;
    public int RaiseCoin;
    public int RaiseCoinPassive;
    public int RaiseRock;
    public int RaiseRockPassive;
    public int RaiseSoldiers;
    public int RaiseSoldiersPassive;
    public int SoldiersOdds;
    public bool GetStartResources;
    public float DelaySpawnRandomRocks;
    public int MultiplierRandomRockValue;
    public bool Boost1Bank;
    public bool Boost2Bank;
    public bool Boost3Bank;
    public bool Boost4Bank;
    public bool Boost5Bank;
    public bool Boost6Bank;
    public bool Boost7Bank;
    public bool Boost1Mine;
    public bool Boost2Mine;
    public bool Boost3Mine;
    public bool Boost4Mine;
    public bool Boost5Mine;
    public bool Boost6Mine;
    public bool Boost7Mine;
    public bool Boost1Soldiers;
    public bool Boost2Soldiers;
    public bool Boost3Soldiers;
    public bool Boost4Soldiers;
    public bool Boost5Soldiers;
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
    public bool FirstExit;
}
