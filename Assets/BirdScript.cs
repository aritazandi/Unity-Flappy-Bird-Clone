using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidbody;
    public bool isLost;
    public float flapStrength;
    public LogicScript logic;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isLost == true)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            rigidbody.velocity = Vector2.up * flapStrength;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isLost = true;
    }
}
