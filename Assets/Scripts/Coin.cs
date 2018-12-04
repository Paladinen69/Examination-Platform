using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Variabel för antalet mynt man har hittat. static = finns på alla scrips
    public static int score;
    //hur mycket ett mynt är värt.
    public int amount = 1;
    //variabel för myntens rotation
    public float spinSpeed = 180;

    private void Update() //händer varje frame.
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0); //myntet roterar konstant
        
    }
    private void OnTriggerEnter2D(Collider2D collision) // när myntet nuddar något
    {
        if(collision.tag == "Player") //om myntet nuddar något med taggen "Player", i detta fall våran player som vi styr.
        {
            Destroy(gameObject); //myntet försvinner
            Coin.score += amount; //Vår score ökar med variablen amounts värde, i detta fall 1.
        }
    }
}
