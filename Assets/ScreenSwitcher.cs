using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSwitcher : MonoBehaviour
{

    //[SerializeField] private string level;

    public void ButtonMoveScene(string level)
    {
        SceneManager.LoadScene(level);
    }
}
