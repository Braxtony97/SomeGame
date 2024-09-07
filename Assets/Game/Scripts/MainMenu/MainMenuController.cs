using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    void Start()
    { 
        Master.Instance.UIController.OpenView("MainMenu");
        StartCoroutine(CoroutineMainMenu());
    }

    IEnumerator CoroutineMainMenu()
    {
        yield return new WaitForSeconds(5f);
        Master.Instance.MainSceneManager.LoadSceneByName(Enums.Scene.PlayMode);
    }
}
