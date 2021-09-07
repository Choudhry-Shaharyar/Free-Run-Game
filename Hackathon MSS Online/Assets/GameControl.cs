using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // used to change scenes or load previuos ones.
/*
 * Author: Shaharyar Choudhry 
 * Date: June 6, 2020
 * Description: Contains the restart, win and gameOver methods. Will display message if user has won and will restart the game if the user has lost
 **/

public class GameControl : MonoBehaviour
{

    bool gameEnded = false; // creating a boolean variable and assigninging it false


    public GameObject youWinUI; // creating public GameObject variable youWinUI

    public void Win() // win method
    {
        youWinUI.SetActive(true); // opens up a message if the game is complete
    }


    public void GameOver()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("game over");
            Invoke("Restart", 1.3f); // This function calls in the method restart and waits a certain time to call it, in this case 2 seconds
        }
    }

    // restart method
    void Restart ()
    {
        SceneManager.LoadScene("MyGame"); // loads the scene from the start again. The scene is called MyGame
    }
}
