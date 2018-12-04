using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI text; //kollar efter en TextMeshProUGUI, ger variabel namnet text
    // Use this for initialization
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>(); //kallar den komponenten så text finns i spelet
    }

    // Update is called once per frame
    void Update()
    {
        text.text = string.Format("Score: {0:0000}", Coin.score); //skriver antalet poäng. Visar med 4 siffror, tillexempel 0000, 0001, 0002 etc
    }
}
