using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class StartGame : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void LoadTown()
    {
        SceneManager.LoadScene("Town");
    }
    public void CheckSenator()
    {
        SceneManager.LoadScene("SenatorCheck");
    }
}
