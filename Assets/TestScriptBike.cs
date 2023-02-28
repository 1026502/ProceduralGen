using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptBike : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float movement;

    // Start is called before the first frame update
    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        //rb.AddTorque(movement * speed * Time.deltaTime);
        rb.AddForce(speed * Time.deltaTime * rb.velocity);
    }
}
