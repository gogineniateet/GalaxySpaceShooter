using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject astroidPrefab;
    float time;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time > 5f)
        {
            transform.position = new Vector3(8.25f, Random.Range(-4.5f, 4.5f));
            Instantiate(astroidPrefab, transform.position, Quaternion.identity);
            time = 0f;
        }

    }
}
