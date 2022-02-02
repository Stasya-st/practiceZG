using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercntrl : MonoBehaviour
{

    public float speed = 20f;
    private Rigidbody2D rb;
    public float speedjump = 50f;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
            rb.AddForce(Vector2.up * speedjump);
        }
    }
}
