using UnityEngine;
using Unity.Netcode;

public class BallMovement : NetworkBehaviour
{
    private float speedx = 5f;
    private float speedy = 5f;
    private Vector2 direction;

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
        direction = new Vector2(3f,3f).normalized;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         Rigidbody2D rb = GetComponent<Rigidbody2D>();
        GameManager manager = FindFirstObjectByType<GameManager>();
        if (manager.player1Score.Value >= 5 || manager.player2Score.Value >= 5){
            transform.position = new Vector3(0f, 0f, 0f);
        }
        //if (IsServer){
            rb.linearVelocity = direction*speedx;
        //}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (!IsServer) return;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
    
        if (collision.gameObject.name == "Wall (2)" || collision.gameObject.name == "Wall (3)")
        {
         // Reverse  direction
         direction = new Vector2(direction.x, -direction.y);
        }
        if (collision.gameObject.name == "Paddle" || collision.gameObject.name == "Paddle1")
        {
         // Reverse  direction
         direction = new Vector2(-direction.x, -direction.y);
        }

        direction = direction.normalized;

        ICollidable collidable = collision.gameObject.GetComponent<ICollidable>();
        
        if (collidable != null)
        {
            // Object has the interface, call the OnHit method
            collidable.OnHit(collision);
            //Debug.Log("prehit!");
        }
    }
}