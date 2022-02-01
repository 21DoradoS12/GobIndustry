using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnternetCheck : MonoBehaviour
{
    public bool InternetOff = false;
    public GameObject Alert;
    public float TimeExit;
    private OfflineGameInformation offline;
    public bool GetInformation = false;
    void Start()
    {
        
    }
    void Update()
    {
        Scene now_scene = SceneManager.GetActiveScene();
        if (now_scene.name == "Town")
            offline = GameObject.FindObjectOfType<OfflineGameInformation>();
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            Alert.SetActive(true);
            InternetOff = true;
            TimeExit += Time.deltaTime;
            if (TimeExit >= 10)
            {
                Application.Quit();
                Debug.Log("Exit");
            }
        }
        if (now_scene.name == "Town" && GetInformation == false && offline.ShowTable == true)
        {
            GetInformation = true;
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
