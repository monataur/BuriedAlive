using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mist1 : MonoBehaviour
{
    public float startingX = 1.84f;
    public float endingX = -1.84f;
    public Transform mist;
    public Rigidbody2D rb;
    public float speed = 1;
    public float moveValue = -0.01f;
    public bool trueFalse = false;

    private void LateUpdate()
    {
        Vector2 movedatshityeahhhhh = new Vector2(1.84f, mist.position.y);
        Vector2 movedatshityeahhhhh2 = new Vector2(-1.84f, mist.position.y);

        rb.MovePosition(mist.position + new Vector3(moveValue, 0f, 0f) * Time.deltaTime * speed);        

        switch (trueFalse)
        {
            case false:
                if (mist.position.x >= endingX)
                {
                    rb.MovePosition(movedatshityeahhhhh2);
                }
                break;

            case true:
                if (mist.position.x <= endingX)
                {
                    rb.MovePosition(movedatshityeahhhhh);
                }
                break;
        }
    }
}
