    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    /*
     * Author: Shaharyar Choudhry 
     * Date: June 6, 2020
     * Description: Detects if a collision has occured and stops the player from moving. 
     **/

    public class collision : MonoBehaviour
    {
        public PlayersMovement motion; // decalring the PlayersMovement to motion.


        void OnCollisionEnter(Collision collisionInformation) // will tell us information about the collison like what we hit
        {
           if(collisionInformation.collider.tag == "Obstacle") // chnage the tag obstacle to person later. first find how to add people
            {
                motion.enabled = false; // disables the players motions
                FindObjectOfType<GameControl>().GameOver(); // calling the GameOver method to end the game
            }
        }
  
    }
