using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Room Camera
    /*[SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;*/

    public Transform player;
    public float offset = 0;
    public float levelSize = 300;


    private void Update()
    {
        //tansform.position = Vector3.SmoothDamp(transform.position, new Vecto3(currentPosX, transform.position.y, transform.position.z), ref velocity, speed * Time.deltaTime);
        if (player.position.x - offset <= 0)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
        else if (player.position.x + offset >= levelSize)
        {
            transform.position = new Vector3(levelSize, transform.position.y, transform.position.z);
        }else {
            transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        }
        
    }

    public void MoveToPlayer(Transform _player)
    {
        //currentPosX = _player.position.x;
    }
}
