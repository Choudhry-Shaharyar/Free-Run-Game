using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: Shaharyar Choudhry 
 * Date: June 6, 2020
 * Description: Makes the camera follow the players position
 **/

public class PlayersCamera : MonoBehaviour
{

    public Transform player; // used to change the position of the camera through Unity
    public Vector3 position; // data tye that stores 3 floats. This needed since position has 3 variables x,y and z

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + position; // assigingin the camera position.
    }
}
