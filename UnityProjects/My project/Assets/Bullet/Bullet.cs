using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    GameManager gameManager;// not is prevate at this time

    // Start is called before the first frame update
    void Start()
    {
        //beacuse bullet not exist till game play need find GM dif way
        gameManager = GameObject.FindObjectOfType<GameManager>();
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(0f,speed);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        gameManager.AddScore();
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
