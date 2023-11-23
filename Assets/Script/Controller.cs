using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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
