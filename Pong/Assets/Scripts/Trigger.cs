using UnityEngine;

public class Trigger : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D other)
  {
    if (gameObject.CompareTag("LeftScore"))
    {
      GameManager manager = FindFirstObjectByType<GameManager>();
      manager.AddPlayer1Score();

      Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
      other.transform.position = new Vector3(0f, 0f, 0f);
      rb.linearVelocity = new Vector2(3f, 3f);
    }
    else if (gameObject.CompareTag("RightScore"))
    {
      GameManager manager = FindFirstObjectByType<GameManager>();
      manager.AddPlayer2Score();

      Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
      other.transform.position = new Vector3(0f, 0f, 0f);
      rb.linearVelocity = new Vector2(-3f, 3f);
    }
  }
}