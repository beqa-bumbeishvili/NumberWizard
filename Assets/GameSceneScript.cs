using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneScript : MonoBehaviour
{
    public Text RenderedNumber;
    int min;
    int max;
    int guess;

    public void Start()
    {
        min = 1;
        max = 1000;
        guess = 500;
        RenderedNumber.text = guess+"?";
    }
    
    public void GoToStartScene()
    {
        SceneManager.LoadScene("Start");
    }

    public void RightAnswerClick()
    {
        SceneManager.LoadScene("Win");
    }

    public void HigherTextBtnClick()
    {
        min = guess;
        guess = (min + max) / 2;
        RenderedNumber.text = guess+"?";
    }

    public void LowerTextBtnClick()
    {
        max = guess;
        guess = (min + max) / 2;
        RenderedNumber.text = guess + "?";
    }

}
