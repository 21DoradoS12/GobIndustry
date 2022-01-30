using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;
public class SceneLoad : MonoBehaviour
{
    public string path;
    public Save save = new Save();
    private BankResources bank;
    private PassiveIncome passive;
    private EnternetCheck enternet;
    void Start()
    {
        enternet = GameObject.FindObjectOfType<EnternetCheck>();
        passive = GameObject.FindObjectOfType<PassiveIncome>();
        bank = GameObject.FindObjectOfType<BankResources>();
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
    void Update()
    {
    }
    public void LoadMine()
    {
        SceneManager.LoadScene("Mine");
    }
    public void LoadMining()
    {
        SceneManager.LoadScene("MainMining");
    }
    public void LoadBank()
    {
        SceneManager.LoadScene("Bank");
    }
    public void LoadTown()
    {
        SceneManager.LoadScene("Town");
    }
    public void LoadMap()
    {
        SceneManager.LoadScene("Map");
    }
    public void LoadBarracks()
    {
        SceneManager.LoadScene("Barracks");
    }
    public void LoadMineUpgrades()
    {
        SceneManager.LoadScene("MineUpgrades");
    }
    public void LoadBankUpgrades()
    {
        SceneManager.LoadScene("BankUpgrades");
    }
    public void LoadBarracksUpgrades()
    {
        SceneManager.LoadScene("BarrackUpgrades");
    }
    public void LoadTreasury()
    {
        SceneManager.LoadScene("Treasury");
    }
    public void ChooseDungeon()
    {
        SceneManager.LoadScene("ChooseDungeon");
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
        if (now_scene.name != "Bank" && now_scene.name != "MainMining")
        {
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
            save.MultiplierRandomRockValue = bank.MultiplierValueRandomRocks;
            save.DelaySpawnRandomRocks = bank.DelayRockSpawn;
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
}
