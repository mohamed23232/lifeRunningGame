using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwaner : MonoBehaviour
{
    public GameObject pipe;
    private float spawnrate;
    private float timer;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        spawnrate = Random.Range(3f, 6f);
        if (timer < spawnrate)
        {
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
        float low = transform.position.y - height;
        float high = transform.position.y + height;
        float y = Random.Range(low, high);
        Instantiate(pipe, new Vector3(transform.position.x, y, 0), transform.rotation);

    }
}
