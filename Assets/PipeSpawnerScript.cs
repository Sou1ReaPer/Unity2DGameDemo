using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 1.0f;
    public float randomRange = 10.0f;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0.0f;
        }
    }

    void SpawnPipe()
    {
        float minY = transform.position.y - randomRange;
        float maxY = transform.position.y + randomRange;
        Vector3 spawnPos = transform.position + new Vector3(0.0f, Random.Range(minY, maxY), 0.0f);

        Instantiate(pipe, spawnPos, transform.rotation);
    }
}
