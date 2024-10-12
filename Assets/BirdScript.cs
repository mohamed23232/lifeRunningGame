using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D my_rb;
    public float jumpForce;
    public LogicManager logicManager;
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            my_rb.velocity = Vector2.up * jumpForce;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicManager.GameOver();
        isAlive = false;
    }
}
