using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowKey : MonoBehaviour
{

    public static bool yellowKeyIsTaken; //Variabel för om nyckeln är tagen eller inte. static betyder att man kan hämta variablen till andra scrips
    
    // Use this for initialization



 
    
    
    
    void Start()
    {
        YellowKey.yellowKeyIsTaken = false; //i början är keyIsTaken false eftersom nyckeln inte är tagen.
    }
  
    private void OnTriggerEnter2D(Collider2D collision) // när nyckeln nuddar något, nyckeln är en Is Trigger
    {
        if (collision.tag == "Player") //om nyckeln nuddar något med taggen "Player", i detta fall våran player som vi styr.
        {
            Destroy(gameObject); //nyckeln försvinner
            YellowKey.yellowKeyIsTaken = true; //keyIsTaken blir true, sant.
        }
    }

}


