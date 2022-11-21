using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
   

    public void OnCollisionEnter(Collision collision) //used for collision, whenever player 
    {
       if(collision.collider.tag=="Obstacle")
       {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
