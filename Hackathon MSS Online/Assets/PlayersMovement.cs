using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: Shaharyar Choudhry 
 * Date: June 6, 2020
 * Description: This contains how the player will move, its speed and its controls. If player falls off the map the game restarts
 **/

public class PlayersMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    // declaring and initializing varaibles
    public float forwardForce = 1500f;
    public float sidewaysForce = 400f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // This enables the player to move
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            //  ForceMode.VelocityChange makes the left and right movemnt more responsive and gets rid of momentum build up
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // This will move the player right. Time.Delta is used to fix the speed regardless of where the game is played on
        }


        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // This will move the player left. 
        }
        if(rb.position.y < 45f) // if player falls off surface end game. 45 is the height of platfrom
        {
            FindObjectOfType<GameControl>().GameOver(); // ending game
        }
    }
}
