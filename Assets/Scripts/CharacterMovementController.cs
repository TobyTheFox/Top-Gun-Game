using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class CharacterMovementController : MonoBehaviour {
	public float speed;
    public Boundary boundary;

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal") * 0.1f * speed;
        float moveVertical = Input.GetAxis ("Vertical") * 0.1f * speed;

        GetComponent<Transform>().Translate(moveHorizontal, moveVertical, 0);
		GetComponent<Transform>().rotation = new Quaternion(0,0,0,0);
    }

}
