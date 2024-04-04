using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 5.0f;
    Vector3 direction = Vector3.left;
    void Start()
    {
        Invoke("timer", 20);
        Invoke("switchDirection", 10);
    }
    void Update()
    {
        checking();
        transform.Translate(direction * Time.deltaTime * speed);
    }

    void timer()
    {
        Destroy(gameObject);
    }

    void switchDirection()
    {
        direction = Vector3.right;
    }

    void checking()
    {
        if (transform.localPosition.x > 2.89)
        {
            direction = Vector3.left;
        }
        if (transform.localPosition.x < -7)
        {
            direction = Vector3.right;
        }
    }
}
