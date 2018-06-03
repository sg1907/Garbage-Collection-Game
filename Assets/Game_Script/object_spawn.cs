using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class object_spawn : collect_o {

    public GameObject can;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLessWait;
    public int startWait;
    public Text text;
    public int çöp;
   
    public GameObject gameObject2;
    // Use this for initialization
    void Start () {
        StartCoroutine(waitSpawner());
	}
	
	// Update is called once per frame
	void Update () {
        spawnWait = Random.Range(spawnLessWait, spawnMostWait);
	}

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        
        while (true)
        {


            çöp++;
            çöp++;
            çöp++;
            
           
        /*
            if (çöp >700)
            {
                gameObject2.SetActive(true);

            }
        */  
            Instantiate(can, GameObject.Find("Student1").transform.position + new Vector3(1,0.06f,0), Quaternion.identity);

            can.tag = "Pick_up";

            yield return new WaitForSeconds(spawnWait);
           
            text.text = "Total Number Of     Trash Left : " + çöp;
          

        }

    }
}
