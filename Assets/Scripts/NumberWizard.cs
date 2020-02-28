using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int intmax;
    [SerializeField] int intmin;
    [SerializeField] TextMeshProUGUI guessText;

    int intGuess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        intGuess = (intmax + intmin) / 2;
        guessText.text = intGuess.ToString();
        intmax = intmax + 1;
    }
    
    public void OnPressHigher()
    {
        intmin = intGuess;
        NextGuess();
    }

    public void OnPressLower()
    {
        intmax = intGuess;
        NextGuess();
    }
    
    void NextGuess()
    {
        intGuess = (intmax + intmin) / 2;
        guessText.text = intGuess.ToString();
    }

}