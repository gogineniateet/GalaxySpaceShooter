using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject astroidPrefab;
    float time;
    public GameObject backGround;
    float x = 0;

    public void Start()
    {
        InvokeRepeating("Spawning", 0f, 1f);
    }


    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time > 3.0f)
        {
            transform.position = new Vector3(8.25f, Random.Range(-4.5f, 4.5f),0);
            Instantiate(astroidPrefab, transform.position, Quaternion.identity);
            time = 0.0f;
        }
    }

    public void Spawning()
    {
        Instantiate(backGround, new Vector3(x, 0, 0), Quaternion.identity);
        x = x + 18;

    }
}








