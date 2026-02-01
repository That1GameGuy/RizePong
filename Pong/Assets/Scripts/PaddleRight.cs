using UnityEngine;

public class PaddleRight: PaddleMovement
{
    protected override float getInput()
    {
        return Input.GetAxis("PaddleRight");
    }
}