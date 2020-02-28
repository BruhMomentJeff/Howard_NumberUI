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
        NextGuess();
    }
    
    public void OnPressHigher()
    {
        intmin = intGuess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        intmax = intGuess - 1;
        NextGuess();
    }
    
    void NextGuess()
    {
        intGuess = Random.Range(intmin, intmax + 1);
        guessText.text = intGuess.ToString();
    }

}