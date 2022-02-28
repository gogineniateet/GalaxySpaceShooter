using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector3 offset,offset1,offset2;
    public AudioClip audioClip;
    public AudioSource bulletSound;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //  Here, method for triple shot. triple shot means releasing 3 bullets at a time.
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.identity);
            bulletSound.clip = audioClip;
            bulletSound.Play();
            // time = 0.0f;

        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            //GameObject.Find("SpaceShip").SetActive(true);
            //Left wing bullet position
            Instantiate(bulletPrefab, transform.position + offset1, Quaternion.identity);
            // Center bullet position
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.identity);
            // Right wing bullet position
            Instantiate(bulletPrefab, transform.position + offset2, Quaternion.identity);
            bulletSound.clip = audioClip;
            bulletSound.Play();
        }

    }
}
