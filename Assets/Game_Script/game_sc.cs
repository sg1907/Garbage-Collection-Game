using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

using System;

public class game_sc : MonoBehaviour {
    public Text text;
    public Text text2;
    int Highscore;
    int score;
    // Use this for initialization


    void Start () {
        string path = "Assets/highscore.txt";
        string[] na = new string[2];

        StreamReader reader = new StreamReader(path);
        string name = reader.ReadToEnd();
        na = name.Split(':');
        Highscore = int.Parse(na[1]);
        reader.Close();

        text2.text = "Highscore :" + Highscore;
      

        ////////////////////////////////////////////////////score///////////////////////////////////////////////
        string scr = "Assets/score.txt";
        string[] sc = new string[2];

        StreamReader r = new StreamReader(scr);
        string sam = r.ReadToEnd();
        sc= sam.Split(':');
        score= int.Parse(sc[1]);
        r.Close();

        text.text = "Yourscore :" + score;
        
    }

    // Update is called once per frame
    void Update () {
        
		
	}
}
