using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class student2_sc : MonoBehaviour
{

    public GameObject can;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLessWait;
    public int startWait;
   

    
    // Use this for initialization
    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLessWait, spawnMostWait);
    }

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {
           
          
            
             Instantiate(can, GameObject.Find("Student2").transform.position + new Vector3(1, 0.06f, 0), Quaternion.identity);
            /* Instantiate(can, GameObject.Find("Student3").transform.position + new Vector3(1, 0.06f, 0), Quaternion.identity);
             Instantiate(can, GameObject.Find("Student4").transform.position + new Vector3(1, 0.06f, 0), Quaternion.identity);
            */
            can.tag = "Pick_up";

            yield return new WaitForSeconds(spawnWait);

           


        }

    }
}
