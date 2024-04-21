using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Cube : MonoBehaviour
{
    public UnityEvent EventOnCollisionWall;
    public UnityEvent EventOnCollisionGround;
    private void OnCollisionEnter(Collision collision)
    {
        Wall wall = collision.collider.GetComponent<Wall>();
        Ground ground = collision.collider.GetComponent<Ground>();

        if (wall)
        {
            EventOnCollisionWall.Invoke();
        }
        else if (ground)
        {
            //EventOnCollisionWall.Invoke();
            EventOnCollisionGround.Invoke();
            Destroy(gameObject);
        }
    }
}
