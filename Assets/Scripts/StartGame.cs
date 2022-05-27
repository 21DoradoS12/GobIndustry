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
    void FixedUpdate()
    {
        
    }
    public void LoadTown()
    {
        SceneManager.LoadScene("Town");
    }
}
