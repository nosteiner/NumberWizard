using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = max + 1;
        guess = (min + max) / 2;

    }

    void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    void OnPressLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
    }
}
