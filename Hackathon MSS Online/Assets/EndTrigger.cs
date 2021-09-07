    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

   /*
   * Author: Shaharyar Choudhry 
   * Date: June 6, 2020
   * Description: Checks to see if finish line is reached using trigger, if so the win method is called
   **/

public class EndTrigger : MonoBehaviour
    {

        public GameControl gameControl; // declaring public variable gameControl

     void OnTriggerEnter ()
        {
            gameControl.Win(); // calling the win method is finish line is reached
        }
    }
