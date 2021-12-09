using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // allows us to write code for UI

/*
 * Author: Shaharyar Choudhry 
 * Date: June 6, 2020
 * Description: Score displayer. Displays distance travelled by player
 **/
public class Score : MonoBehaviour
{
    
    // creatign variables
    public Transform player;
    public Text scoreText;


    // Update is called once per frame
    void Update()

    {
        // usuing the players Z position as its distnace travelled(Score)
        scoreText.text = player.position.z.ToString("0"); // using toString to convert number into text whith whole numbers
    }
}
