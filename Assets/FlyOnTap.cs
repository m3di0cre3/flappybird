using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyOnTap : MonoBehaviour
{
    public float velocity = 0.02f;
    private Rigidbody2D rigidBod2D;

    void Start()
    {
        rigidBod2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rigidBod2D.velocity = Vector2.up * velocity;
        }
    }
}
