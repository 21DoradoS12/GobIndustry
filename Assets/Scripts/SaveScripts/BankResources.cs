using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
public class BankResources : MonoBehaviour
{
    public string path;
    public Save save = new Save();
    public GameObject NeedToSave;
    public GameObject GobMassanger;
    public bool getResources;
    private bool Sve = true;
    public long MoneyToNewScene;
    public long RockToNewScene;
    public long SoldiersToNewScene;
    public long CoinApp;
    public long RockApp;
    public long SoldiersApp;
    public long SoldiersAppOdds;
    public long CoinAppPassive;
    public long RockAppPassive;
    public long SoldiersAppPassive;
    public long MultiplierValueRandomRocks;
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
    public long MaxOfflineTime;
    public long BoostOfflineEarn;
    public long Chest1Time;
    public bool AvaliableChest1;
    public bool AvaliableChest2;
    public long DungeonTimeLeft;
    public bool DungeonOn1;
    public bool DungeonOn2;
    public long Chest1Count;
    public long Chest2Count;
    public bool level1;
    public bool level2;
    public bool level3;
    public bool level4;
    public bool level5;
    public bool level6;
    public float TimeForBattle;
    public bool StartGlobalBattleTimer;
    public bool StartGlobalDangeonTimer;
    public bool FirstOpenCandidats;
    public long NumCurrentCandidat;
    public float CandidatsTime;
    public long LevelGob1;
    public long LevelGob2;
    public long LevelGob3;
    public long Gob1Fragment;
    public long Gob2Fragment;
    public long Gob3Fragment;
    public long CountBonusesBank;
    public long CountBonusesMine;
    public long CountBonusesSoldiers;
    public long TownLevel;
    private EnternetCheck enternet;
    public int CountKillCollector;
    public bool CollectorHere;
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
            if (enternet.InternetOff == false && save.FirstExit == true)
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
            level1 = save.level1;
            level2 = save.level2;
            level3 = save.level3;
            level4 = save.level4;
            level5 = save.level5;
            level6 = save.level6;
            TimeForBattle = save.TimeForBattle;
            StartGlobalBattleTimer = save.StartGlobalBattleTimer;
            StartGlobalDangeonTimer = save.StartGlobalDangeonTImer;
            FirstOpenCandidats = save.FirstOpenCandidats;
            NumCurrentCandidat = save.NumCurrentCandidat;
            CandidatsTime = save.CandidatsTime;
            LevelGob1 = save.LevelGob1;
            LevelGob2 = save.LevelGob2;
            LevelGob3 = save.LevelGob3;
            Gob1Fragment = save.Gob1Fragment;
            Gob2Fragment = save.Gob2Fragment;
            Gob3Fragment = save.Gob3Fragment;
            CountBonusesBank = save.CountBonusesBank;
            CountBonusesMine = save.CountBonusesMine;
            CountBonusesSoldiers = save.CountBonusesSoldiers;
            TownLevel = save.TownLevel;
            CountKillCollector = save.CountKillCollector;
            CollectorHere = save.CollectorHere;
        }
        DontDestroyOnLoad(NeedToSave);
        DontDestroyOnLoad(GobMassanger);
        if (MaxOfflineTime == 0)
            MaxOfflineTime = 1800;
        if (BoostOfflineEarn == 0)
            BoostOfflineEarn = 1;
    }
    void FixedUpdate()
    {
        if (getResources == true)
            TaxesTime += Time.deltaTime;
    }
}
