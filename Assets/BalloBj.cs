using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloBj : MonoBehaviour
{
    public float speed;


    private void Start()
    {
        Destroy(gameObject,0.2f);
    }
    private void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

}
