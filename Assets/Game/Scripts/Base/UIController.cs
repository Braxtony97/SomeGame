using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject[] _uiGameObjects;

    public void OpenView(string name)
    {
        foreach (GameObject view in _uiGameObjects)
        {
            if (view.name == name)
            {
                Instantiate(view, transform);
            }
        }
    }

    public void CloseView()
    {
        foreach (GameObject view in _uiGameObjects)
        {
            Destroy(view);
        }
    }
}
