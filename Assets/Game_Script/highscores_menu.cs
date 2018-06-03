using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class highscores_menu : MonoBehaviour {

    public Text text1;
    public Text text2;
    
    int[] scores = new int[2];

    int highscore = 0;
    int temp_score = 0;

    void Start () {
        for (int i = 0; i < 2; i++) scores[i] = 0;

        //////// High Score
        string path = "Assets/highscore.txt";
        string[] na = new string[2];

        StreamReader reader = new StreamReader(path);
        string name = reader.ReadToEnd();
        na = name.Split(':');
        highscore = int.Parse(na[1]);
        reader.Close();

        //////// Last Score

        string path2 = "Assets/score.txt";
        string[] na2 = new string[2];

        StreamReader reader2 = new StreamReader(path2);
        string name2 = reader2.ReadToEnd();
        na2 = name2.Split(':');
        temp_score = int.Parse(na2[1]);
        reader.Close();

        text1.text = "Score : " + highscore;
        text2.text = "Score : " + temp_score;
    }

}