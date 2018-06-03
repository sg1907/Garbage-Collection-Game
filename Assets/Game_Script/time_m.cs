using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class time_m : MonoBehaviour {

   public Text text;

    float timeLeft = 300.0f;

    void Update()
    {
        timeLeft=timeLeft-Time.deltaTime;
        text.text = "Remaining Time : " + timeLeft;
        if (timeLeft < 0)
        {
            Application.LoadLevel("gameOver");
            
        }
    }
}
