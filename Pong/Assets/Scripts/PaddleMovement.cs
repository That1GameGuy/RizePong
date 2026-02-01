using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float speed = 0.01f;

    protected virtual float getInput(){
        return Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        transform.position += new Vector3(0, getInput() * speed, 0);
    }
}
