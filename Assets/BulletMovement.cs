using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    public AudioSource source;
    public AudioClip explosionSound;
    ScoreManager score;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        source = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(bulletSpeed * Time.deltaTime, 0, 0); // giving thr bullet a movement in forward direction
        time = time + Time.deltaTime;

        if (transform.position.x > 8f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "astroid")
        {
            Destroy(collision.gameObject);
            source.clip = explosionSound;
            source.Play();

            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Score(10); //  score
           
        }
    }

}
