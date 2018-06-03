using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_click : MonoBehaviour {


    public void newScene(int baslat)
    {
        Application.LoadLevel(baslat);
    }

    public void exit()
    {
        Application.Quit();
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
