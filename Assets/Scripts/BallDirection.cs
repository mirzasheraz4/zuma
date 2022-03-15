using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDirection : MonoBehaviour
{
    Transform FirePoint;
    Rigidbody BallRb;
    int BallMovSpeed = 20;
    void Start()
    {
        BallRb = GetComponent<Rigidbody>();
        FirePoint = GameObject.Find("FirePoint").GetComponent<Transform>();
    }

    void Update()
    {
        BallRb.AddForce(FirePoint.transform.position * BallMovSpeed * Time.deltaTime ,ForceMode.Impulse);
    }
}
