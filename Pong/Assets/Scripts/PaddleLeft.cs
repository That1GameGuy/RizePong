using UnityEngine;

public class PaddleLeft: PaddleMovement
{
    protected override float getInput()
    {
        return Input.GetAxis("PaddleLeft");
    }
}