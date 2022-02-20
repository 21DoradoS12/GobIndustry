using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;
using UnityEngine.UI;
public class SceneLoad : MonoBehaviour
{
    public string path;
    public Save save = new Save();
    private BankResources bank;
    private PassiveIncome passive;
    private EnternetCheck enternet;
    public bool FirstExit;
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
        FirstExit = save.FirstExit;
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
}
