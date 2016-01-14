using UnityEngine;
using System.Collections;

public class ScreenEdgeRecycler : MonoBehaviour
{
    float VerticalBounds = 7f;
    float HorizontalBounds = 13f;
    
	void Update ()
    {
        if (CheckBounds(transform.position.x, HorizontalBounds))
            RecycleHorizontal();

        if (CheckBounds(transform.position.y, VerticalBounds))
            RecycleVertical();
    }

    bool CheckBounds(float position, float bound)
    {
        return position > bound || position < bound * -1;
    }
    
    // TODO: Make this the same function... somehow.
    void RecycleHorizontal()
    {
        Vector3 position = transform.position;
        position.x *= -1;

        transform.position = position;
    }

    void RecycleVertical()
    {
        Vector3 position = transform.position;
        position.y *= -1;

        transform.position = position;
    }
}
