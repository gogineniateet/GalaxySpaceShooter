using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour
{

    public float astroidSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * astroidSpeed * Time.deltaTime);
        transform.Rotate(5.0f,0f,0f, Space.Self);

        if (transform.position.x < -9f)
        {
            Destroy(gameObject,3.0f);
        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "astroid")
        {
            Destroy(collision.gameObject);

        }
    }


    //private void OnBecameInvisible()
    //{
    //    Destroy(gameObject);
    //}



}
