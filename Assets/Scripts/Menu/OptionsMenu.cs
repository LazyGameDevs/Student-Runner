﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public string backMainMenu;

    public void MainMenu()
    {
        SceneManager.LoadScene(backMainMenu);
    }
}
