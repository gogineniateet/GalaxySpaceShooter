using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMovement : MonoBehaviour
{

    public float movementSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-movementSpeed * Time.deltaTime,0,0);

    }
}
