using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;//stores a vector
    // Update is called once per frame
    void Update()
    {
        //tranform.refering to the current calling game object on which it is sitting on==Camera
        transform.position = player.position+offset; 


    }
}
