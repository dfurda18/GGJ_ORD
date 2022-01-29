using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public float jumpForce;

    private Rigidbody2D rigid;
    public bool  isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       PlayerMovements();
       Jump();
    }

    void PlayerMovements()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;

        float inputAxis = Input.GetAxis("Horizontal");
        
        // Player looking to the right
        if(inputAxis > 0){
            transform.eulerAngles = new Vector2(0f, 0f);
        }

        // Player looking to the left
        if(inputAxis < 0){
            transform.eulerAngles = new Vector2(0f, 180f);
        }
    }

    
    void Jump()
    {
        if(Input.GetButtonDown("Jump") && !isJumping)
        {
            rigid.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

}
