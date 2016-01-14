using UnityEngine;
using System.Collections;

public class ShipRotate : MonoBehaviour
{
    public float rotationSpeed;

    public KeyCode rotationLeft;
    public KeyCode rotationRight;

	void Update ()
    {
        float frameRotation = 0;

        if (Input.GetKey(rotationLeft))
            frameRotation += rotationSpeed * Time.deltaTime;

        else if (Input.GetKey(rotationRight))
            frameRotation += rotationSpeed * -1 * Time.deltaTime;

        transform.Rotate(new Vector3(0, 0, frameRotation));
	}
}
