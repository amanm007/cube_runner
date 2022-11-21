using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; //referencing rigibody and assigning it to player
    public float forwardForce = 2000f;
    public float sideForce=500f;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Unity"); //allow us to write messages
        // rb.useGravity = false; //setting properties
        //rb.AddForce(0, 200, 500); //(x,y,z)
    }

    // Update is called once per frame
    void FixedUpdate()//unity likes fixed update since we are using physics components
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //adding forward force

        if(Input.GetKey("d") ||Input.GetButtonDown("Fire1"))//not the most efficient input method
            //move to right along x axis
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")) //move to left, along -x axis(oppposite)
        {
            rb.AddForce(-sideForce * Time.deltaTime,0, 0,ForceMode.VelocityChange);
        }
        if(rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
