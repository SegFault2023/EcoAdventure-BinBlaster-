using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Following Object")]
    public Transform player;
    [Header("Boundries")]
    public float boundX = 0.15f;
    public float boundY = 0.05f;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        float deltaX = player.position.x - transform.position.x;

        if (deltaX > boundX || deltaX < -boundX)
        {
            if(transform.position.x < player.position.x)
            {
                delta.x = deltaX - boundX;
            }
            else
            {
                delta.x = deltaX + boundX;
            }
        }

        float deltaY = player.position.y - transform.position.y;

        if(deltaY > boundY || deltaY < -boundY)
        {
            if(transform.position.y < player.position.y)
            {
                delta.y = deltaY - boundY;
            }
            else
            {
                delta.y = deltaY + boundY;
            }
        }



        transform.position += new Vector3(delta.x,delta.y,0);
    }
}
