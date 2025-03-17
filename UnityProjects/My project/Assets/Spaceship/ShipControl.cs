using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{

    public GameManager gameManager;
    public GameObject bulletPrefab;
    public float speed = 10f;
    public float xLimit = 7f;
    public float reloadTime = 0.5f;
    float elapsedTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //keep track of time for bullet firing
        elapsedTime += Time.deltaTime;

        //move player left and right
        float xInput = Input.GetAxis("Horizontal");
        transform.Translate(xInput * speed * Time.deltaTime, 0f,0f );
        // clamp the ships x pos
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -xLimit, xLimit);
        transform.position = position;
        // spacebar fires default input manager ca;; this jump
        // only happens if enough time has passed
        if(Input.GetButtonDown("Jump") && elapsedTime > reloadTime)
        {
            // create bullet 1.23 u from player
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0, 1.2f, 0);
            Instantiate(bulletPrefab, spawnPos, Quaternion.identity);
            elapsedTime = 0f; //Reset bullet firing time
        }
    }

    //if meteor hit player
    void OnTriggerEnter2D(Collider2D other)
    {
        gameManager.PlayerDied();
    }

}
