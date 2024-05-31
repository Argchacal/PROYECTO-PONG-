using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D ballRb;
    [SerializeField]private float velocityMultiplier = 1.1f;
    //estamos incrementando la velocidad 10%cada vez que coliciona
    [SerializeField]private float  initialVelocity = 4f;
    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        Launch();
    }
    private void Launch()
    {
        float xVelocity = Random.Range(0, 2) == 0 ? 1: -1;//0 ? 1: -1 es como un if
        float yVelocity = Random.Range(0, 2) == 0 ? 1: -1;//0 ? 1: -1 es como un if
        ballRb.velocity = new Vector2(xVelocity, yVelocity) * initialVelocity;
    }
    //evalucamos la colicion
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("paddle"))
        {
            ballRb.velocity *= velocityMultiplier;
        }    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
