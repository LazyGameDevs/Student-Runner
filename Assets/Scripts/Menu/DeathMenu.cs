﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{

    public string mainMenuLevel;



    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScoreMenager theScoreManager = FindObjectOfType<ScoreMenager>();
        if(theScoreManager) theScoreManager.scoreCounter = 0;
    }

    public void QuitToMain()
    {
        SceneManager.LoadScene(mainMenuLevel);
    }

}
