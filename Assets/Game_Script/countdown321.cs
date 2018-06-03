using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class countdown321 : MonoBehaviour {

    public Text text;
    float countdown = 3.0f;
	void Start () {

       
    }
	
	// Update is called once per frame
	void Update () {

        countdown = countdown - Time.deltaTime;
        text.text = "Time : " + countdown;
        if (countdown < 0)
        {
            Application.LoadLevel(2);

        }
	}
}
