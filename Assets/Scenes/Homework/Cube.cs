using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Cube : MonoBehaviour
{
    public UnityEvent EventOnCollision;
    private void OnCollisionEnter(Collision collision)
    {
        Wall wall = collision.collider.GetComponent<Wall>();
        Ground ground = collision.collider.GetComponent<Ground>();

        if (wall)
        {
            EventOnCollision.Invoke();
        }
        else if (ground)
        {
            EventOnCollision.Invoke();
            Destroy(gameObject);
        }
    }
}
