using UnityEngine;
using Unity.Netcode;

public abstract class PaddleMovement : NetworkBehaviour, ICollidable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float speed = 0.01f;

    protected abstract float getInput();

    private NetworkVariable<float> yPos = new NetworkVariable<float>(0f);
    private NetworkVariable<float> syncedYPosition = new NetworkVariable<float>(0f);

    // Update is called once per frame
    void FixedUpdate()
    {
        if (IsOwner)
        {
            //transform.position += new Vector3(0, getInput() * speed, 0);

            float newY = transform.position.y + (getInput() * speed * Time.deltaTime);
        
            yPos.Value = newY;

            transform.position = new Vector3(transform.position.x, newY, 0);
            
            // Update NetworkVariable so other clients can see it
            syncedYPosition.Value = newY;
        }else
        {
            // Non-owners: Read NetworkVariable and update visual position
            transform.position = new Vector3(transform.position.x, syncedYPosition.Value, 0);
        }
        
    }

    public void OnHit(Collision2D collision){
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.linearVelocity = new Vector3(0, 0, 0);
            Debug.Log("hit!");
    }
        
}
