using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour
{

    public float astroidSpeed;
    
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

   
    

    //private void OnBecameInvisible()
    //{
    //    Destroy(gameObject);
    //}



}
