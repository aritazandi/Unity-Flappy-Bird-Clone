using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 8;
    public float deadZone = -54;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
        
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
