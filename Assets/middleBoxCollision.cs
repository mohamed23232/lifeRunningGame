using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleBoxCollision : MonoBehaviour
{
    public LogicManager logicManager;
    // Start is called before the first frame update
    void Start()
    {
        // Find the LogicManager object in the scene by tag
        logicManager = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logicManager.IncreaseScore(1);

        }
    }
}
