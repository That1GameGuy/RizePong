using UnityEngine;

public abstract class PaddleMovement : MonoBehaviour, ICollidable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float speed = 0.01f;

    protected abstract float getInput();

    // Update is called once per frame
    void FixedUpdate()
    {
        
        transform.position += new Vector3(0, getInput() * speed, 0);

        
    }

    public void OnHit(Collision2D collision){
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.linearVelocity = new Vector3(0, 0, 0);
            Debug.Log("hit!");
    }
        
}
