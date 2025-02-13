using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CircleLetter : MonoBehaviour, IClickable
{
    private CirclePuzzle circlePuzzle;
    private char letter;

    public void OnClick()
    {
        circlePuzzle.AddLetterToAnswer(letter);
    }

    //Use instead of constructor
    public void InstantiateCircleLetter(char letter, CirclePuzzle circlePuzzle)
    {
        this.letter = letter;
        this.circlePuzzle = circlePuzzle;
        GetComponentInChildren<TMP_Text>().text = letter.ToString();
    }
}