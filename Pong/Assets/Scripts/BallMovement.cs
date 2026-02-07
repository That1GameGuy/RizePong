using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float speedx = 3f;
    private float speedy = 3f;

    public float GetX(){
        return speedx;
    }
    public float GetY(){
        return speedy;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(3f, 3f);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
    
        if (collision.gameObject.CompareTag("Wall"))
        {
         // Reverse  direction
         rb.linearVelocity = new Vector2(speedx, -speedy);
        }
        if (collision.gameObject.CompareTag("Paddle"))
        {
         // Reverse  direction
         rb.linearVelocity = new Vector2(-speedx, -speedy);
        }

        ICollidable collidable = collision.gameObject.GetComponent<ICollidable>();
        
        if (collidable != null)
        {
            // Object has the interface, call the OnHit method
            collidable.OnHit(collision);
            Debug.Log("prehit!");
        }
    }
}