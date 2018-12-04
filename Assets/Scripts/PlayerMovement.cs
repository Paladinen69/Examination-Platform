using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 6f; //variabel för hastigheten vi rör oss i när vi går vänster eller höger
    public float bouncerJumpSpeed = 24f;
    public static float jumpSpeed = 12f;//variabel för hur högt player hoppar. Static innebär att jag kan använda variablen i ett annat script (JumpspeedPowerUp). Börjar på 12
    public GroundChecker groundCheck; 
    

    private Rigidbody2D rbody; //variabel för rigidbody

	// Use this for initialization
	void Start ()
    {
        rbody = GetComponent<Rigidbody2D>(); //hämtar rigidbody
	}
	
	// Update is called once per frame
	void Update () {
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y); //våran rigidbodys hastighet (velocity) = En Vector2 (x, y) där när man trycker ner en Horizontal knapp (A, D och vänsterhöger pilarna) så flyttas karaktärens X värde multipliceras med movespeed. Medans y är densamma (rbody.velocity.y)
        if (Input.GetButtonDown("Jump")) //om en Jump knapp trycks ner (Space)
        {
            if (groundCheck.isGrounded > 0) //om GroundChecker (en collider) nuddar en annan collider
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed); //hastigheten ändrar inte sitt x värde (rbody.velocity.x), men ändrar y.värdet beroende på jumpSpeed.
                
            }
        }
        
    }
    





}
    





