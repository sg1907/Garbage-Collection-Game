using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class collect_o : MonoBehaviour
{
    public GameObject gameObject;
    private bool pressedButton;
    public int score = 0;
    public Text text;
    int Highscore =0;

    public int a { get; set; }
   

   
  void Start()
    {
        string path = "Assets/highscore.txt";
        string []na = new string[2];
        
        StreamReader reader = new StreamReader(path);
        string name=reader.ReadToEnd();
        na = name.Split(':');
        Highscore = int.Parse(na[1]);
        reader.Close();


    }
   void Update()
    {
        // for mouse Input.GetMouseButtonDown(0)
        if (Input.GetKeyDown(KeyCode.C)) // 0 - left button; 1 - right button; 2 - middle button
        {
            pressedButton = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Pick_up")
        {           
            if (pressedButton)
            {
                Destroy(collision.gameObject);
                score++;
                text.text = "Score : " + score;
                string scr = "Assets/score.txt";
                System.IO.File.WriteAllText(scr, string.Empty);
                StreamWriter writ = new StreamWriter(scr, true);
                writ.WriteLine("YourScore:" + score);
                writ.Close();
                a = score;
                                
                if (score > Highscore)
                {
                    Highscore = score;

                    string path = "Assets/highscore.txt";

                    System.IO.File.WriteAllText(path, string.Empty);
                    StreamWriter writer = new StreamWriter(path, true);
                    writer.WriteLine("Highscore:" + Highscore);
                    writer.Close();

                }
                pressedButton = false;
            }
           
        }
        else if(collision.transform.tag != "Pick_up")
        {
            
            text.text = "Score : " + score;
            string scr = "Assets/score.txt";
            System.IO.File.WriteAllText(scr, string.Empty);
            StreamWriter writ = new StreamWriter(scr, true);
            writ.WriteLine("YourScore:" + score);
            writ.Close();

        }
       
    }
  
   
}