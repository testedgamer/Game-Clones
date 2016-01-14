using UnityEngine;
using System.Collections;

public class ShipThrust : MonoBehaviour
{
    public float thrustPower;
    public KeyCode thrustKey;

    Rigidbody2D physics;

    void Start()
    {
        physics = gameObject.GetComponent<Rigidbody2D>();
    }


	void Update ()
    {
        if(Input.GetKey(thrustKey))
            physics.AddForce(transform.right * thrustPower);
	}

}
