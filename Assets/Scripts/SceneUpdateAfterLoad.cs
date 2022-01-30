using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneUpdateAfterLoad : MonoBehaviour
{
    public bool lol;
    void Start()
    {
        lol = false;
    }
    void Update()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (lol == false)
        {
            Debug.Log("OnSceneLoaded: " + scene.name);
            Debug.Log(mode);
            lol = true;
        }
    }
}
