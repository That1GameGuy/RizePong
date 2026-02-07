/*
using UnityEngine;
public class IsAWall : MonoBehaviour, ICollidable
{
    public void OnHit(Collision2D collision){
            
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.linearVelocity = new Vector2(collision.gameObject.GetComponent<BallMovement>().GetX(), -GetComponent<BallMovement>().GetY());
            Debug.Log("Wallhit!");
    }
}
*/