using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager
{
    public void LoadSceneByName(Enums.Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());  
    }

    public void LoadSceneById(int id)
    {
        //to think about
    }
}
