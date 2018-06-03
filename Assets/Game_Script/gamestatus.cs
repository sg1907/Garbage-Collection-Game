using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamestatus : MonoBehaviour {


    public void NewGame()
    {
        Application.LoadLevel(1);
    }
    public void HighScore()
    {
        Application.LoadLevel(4);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void ReturnMenu()
    {
        Application.LoadLevel(0);
    }

}
