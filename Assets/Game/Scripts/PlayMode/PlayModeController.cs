using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayModeController : MonoBehaviour
{
    private void Start()
    {
        Master.Instance.UIController.OpenView("PlayMode");
    }
}
