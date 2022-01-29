using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    Player Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject.GetComponent<Player>();    
    }
    
    // Detect if the player is stand on the ground. So, he can jump
    void OnCollisionEnter2D(Collision2D collisor)
    {
        if(collisor.gameObject.tag == "Ground")
        {
            Player.isJumping = false;
        }
    }

    
    
    void OnCollisionExit2D(Collision2D collisor)
    {
         if(collisor.gameObject.tag == "Ground")
        {
            Player.isJumping = true;
        }
    }
}
