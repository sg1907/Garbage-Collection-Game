using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameSc : MonoBehaviour
{
    
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
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void Scores()
    {
        Application.LoadLevel(2);
    }

    //public void MainMenu()
    //{
    //    Application.LoadLevel(0);
    //}

    // Update is called once per frame
    void Update()
    {

    }
}