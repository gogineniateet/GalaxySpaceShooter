using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;

    // Update is called once per frame
     void Update()
     {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * playerSpeed * inputY * Time.deltaTime);
        transform.Translate(Vector3.right * playerSpeed * inputX * Time.deltaTime);
        if (transform.position.y > 4.5f )
        {         
            transform.position = new Vector3(transform.position.x,4.5f,0);            
        }
        else if (transform.position.y < -4.5f)
        {            
            transform.position = new Vector3(transform.position.x, -4.5f,0);
        }
        if (transform.position.x > 7f ) 
        {
            transform.position = new Vector3(7f, transform.position.y,0);
        }
        else if(transform.position.x < -7f)
        {
            transform.position = new Vector3(-7f, transform.position.y, 0);
        }


     }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "astroid")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Game restarted.......");
        }
    }



}
