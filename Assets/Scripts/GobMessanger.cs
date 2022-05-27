using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GobMessanger : MonoBehaviour
{
    public GameObject GobSprite;
    public GameObject MessageAboutExtraTaxes;
    private BankResources bank;
    public bool showGobMessager;
    private SceneLoad sceneload;
    void Start()
    {
        GobSprite.SetActive(false);
        MessageAboutExtraTaxes.SetActive(false);
        bank = GameObject.FindObjectOfType<BankResources>();
        sceneload = GameObject.FindObjectOfType<SceneLoad>();
    }
    void FixedUpdate()
    {
        if (bank.TaxesTime <= 10)
        {
            showGobMessager = false;
        }
        if (bank.TaxesTime >= 360)
        {
            float NewMoney = bank.MoneyToNewScene * 0.8f;
            bank.MoneyToNewScene = Mathf.RoundToInt(NewMoney);
            float NewRock = bank.RockToNewScene * 0.8f;
            bank.RockToNewScene = Mathf.RoundToInt(NewRock);
            float NewSoldiers = bank.SoldiersToNewScene * 0.8f;
            bank.SoldiersToNewScene = Mathf.RoundToInt(NewSoldiers);
            Debug.Log("Gob collector get 20% of your resurces and gone...");
            bank.TaxesTime = 0;
            GobSprite.SetActive(false);
            MessageAboutExtraTaxes.SetActive(false);
            showGobMessager = false;

        }
        if (bank.TaxesTime >= 320 && showGobMessager == true)
        {
            GobSprite.SetActive(false);
            MessageAboutExtraTaxes.SetActive(false);
        }
        if (bank.TaxesTime >= 300 && showGobMessager == false)
        {
            Scene now_scene = SceneManager.GetActiveScene();
            if (now_scene.name != "Town")
            {
                showGobMessager = true;
                GobSprite.SetActive(true);
                MessageAboutExtraTaxes.SetActive(true);
            }
        }
    }
    public void GoToTaxesGob()
    {
        showGobMessager = true;
        GobSprite.SetActive(false);
        MessageAboutExtraTaxes.SetActive(false);
        sceneload.NumSceneNow = 1;
        SceneManager.LoadScene("Bank");
    }
    public void IgnoreTaxesGob()
    {
        showGobMessager = true;
        GobSprite.SetActive(false);
        MessageAboutExtraTaxes.SetActive(false);
    }
}
