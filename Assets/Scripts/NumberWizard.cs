using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int intmax;
    [SerializeField] int intmin;
    int intGuess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        intmax = intmax + 1;
        intGuess = (intmax + intmin) / 2;
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
    }

}