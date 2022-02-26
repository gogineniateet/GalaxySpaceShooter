using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    float time;
    public Vector3 offset;
    
    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if(time >=0.2f)
        {
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.identity);
            time = 0f;
        }
    }
}
