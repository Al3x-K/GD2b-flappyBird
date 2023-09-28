using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public bool isDead = false;
    public float velocity = 2.4f;
    private Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rigidbody.velocity = Vector2.up * velocity;
        }

    }
    private void OnCollision(Collision2D other)
    {
        isDead = true;
        gameManager.GameOver();
    }
}
