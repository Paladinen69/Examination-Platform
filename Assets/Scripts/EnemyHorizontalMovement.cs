using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHorizontalMovement : MonoBehaviour
{
    public float speed = 20f; //variabel för hastighet
    public bool isLeft = true; // variabel för att se om det är sant eller falskt att råttan tittar åt vänster
    private Rigidbody2D rbody; //variabel för rigidbody
  

    
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>(); //hämtar Rigidbody
        
    }
  

    private void FixedUpdate()
    {
        // är råtan till vänster: hastighet säts till negativ (negativ är till vänster, positiv till höger). Råttan vänds också så den tittar till vänster med transform.localScale
        if (isLeft == true)
        {
            rbody.velocity = -(Vector2)transform.right * speed * ((Coin.score * 0.1f) + 1); //transform är Vector 3 (x,y och z), men vi gör om den till en Vector 2(x och y). Multipliceras med variablen speed. NYTT!: Råttorna blir snabbare beroende på hur många mynt man har tagit, dom gillar inte att man tar deras mynt (variabel Coin.score)

            transform.localScale = new Vector3(1, 1, 1); //scalas så den tittar åt vänster
            
        }
        else // om råttan inte är till vänster, så gör den samma sak som innan fast hastigheten är positiv, alltså till höger. Även vänds till höger
        {
            rbody.velocity = (Vector2)transform.right * speed * ((Coin.score * 0.1f) + 1); //Samma som innan fast positiv istället för negativ. NYTT!: Råttorna blir snabbare beroende på hur många mynt man har tagit, dom gillar inte att man tar deras mynt
            transform.localScale = new Vector3(-1, 1, 1); //scalas så den tittar åt vänster
        }
        
    }
   
    private void OnTriggerEnter2D(Collider2D collision) //när den nuddar något
    {
        if (collision.tag == "InvisibleWall") //om råttan nuddar en osynlig collider som finns i Unity för att råttan ska vända istället för att krocka i vägar eller gå över stup, så blir isLeft false, alltså går den åt höger och vänds till höger.
        {
            isLeft = !isLeft; //= Vänster = Inte Vänster
        }
        

    }
}
