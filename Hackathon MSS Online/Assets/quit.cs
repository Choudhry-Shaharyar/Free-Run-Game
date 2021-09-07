using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Author: Shaharyar Choudhry 
 * Date: June 6, 2020
 * Description: quits application
 **/

public class quit : MonoBehaviour
{
    public void doquit()
    {
        Debug.Log("game quit");
        Application.Quit();
    }


}
