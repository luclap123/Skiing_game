using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float boostSpeed = 35f;
    [SerializeField] float normalSpeed = 20f;
    bool canMove = true;
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            SpeedPlayer();
        }
    }

    public void disableControl()
    {
        canMove = false;
    }

    private void SpeedPlayer()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = normalSpeed;

        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2D.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody2D.AddTorque(-torqueAmount);
        }
    }
}
