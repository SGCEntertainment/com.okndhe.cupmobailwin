using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float speed;
    int dir = 1;

    private void Start()
    {
    }

    private void Update()
    {
        if (transform.position.x > 1.5f || transform.position.x < -1.5f)
        {
            dir *= -1;
        }

        transform.position += Vector3.right * speed *dir * Time.deltaTime;
    }
}
