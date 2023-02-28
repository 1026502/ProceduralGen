using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{

    public Rigidbody2D backWheel;
    public Rigidbody2D frontWheel;
    public Rigidbody2D carRB;
    public float carTorque;
    public float speed;

    private float movement;
    private float vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Debug Horizontal");
    }

    private void FixedUpdate()
    {
        backWheel.AddTorque(-movement * speed * Time.fixedDeltaTime);
        frontWheel.AddTorque(-movement * speed * Time.fixedDeltaTime);
        carRB.AddTorque(-movement * carTorque * Time.fixedDeltaTime); ;


    }
}
