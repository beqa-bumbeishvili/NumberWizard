﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneScript : MonoBehaviour
{
    public void GoToStartScene()
    {
        SceneManager.LoadScene("Start");
    }
}
