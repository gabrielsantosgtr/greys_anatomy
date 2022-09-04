using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    private Vector2 lastClikedPos;
    private bool moving;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastClikedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        if(moving && (Vector2)transform.position != lastClikedPos)
        {
            float step = movementSpeed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClikedPos, step);
        }
        else
        {
            moving = false;
        }
    }
}
