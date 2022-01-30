using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnternetCheck : MonoBehaviour
{
    public bool InternetOff = false;
    public GameObject Alert;
    public float TimeExit;
    void Start()
    {
        
    }
    void Update()
    {
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
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
