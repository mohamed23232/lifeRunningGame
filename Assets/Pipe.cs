using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;
    private float deadzone = -30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < deadzone)
        {
            Debug.Log("Destroying pipe");
            Destroy(gameObject);
        }
    }
}
