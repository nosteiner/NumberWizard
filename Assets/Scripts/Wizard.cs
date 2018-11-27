using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Wizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
  //  [SerializeField] TextMeshProUGUI guessesCounterText;
    int guess;
   

    // Use this for initialization
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            StartGame();
        }
  
    }

    void StartGame()
    {
        guess = (min + max) / 2;
      //  Static.guessesCounter = 0;
        guessText.text = guess.ToString();
        max = max + 1;
    }

   public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);
        //Static.guessesCounter++;
        guessText.text = guess.ToString();
        //guessesCounterText.text = Static.guessesCounter.ToString();
    }
}
