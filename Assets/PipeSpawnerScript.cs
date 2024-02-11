using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Pipe;
    public float Spawnrate;
    private float timer;
    public float heightOffSet = 10;
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < Spawnrate) { 
            timer += Time.deltaTime; 
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }
    void SpawnPipe()
    {
        float LowestOffSet = transform.position.y - heightOffSet;
        float HighestOffSet = transform.position.y + heightOffSet;
        Instantiate(Pipe, new Vector3(transform.position.x,Random.Range(LowestOffSet,heightOffSet),0), transform.rotation);

    }
}
