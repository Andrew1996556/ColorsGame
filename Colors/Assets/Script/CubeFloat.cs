using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFloat : MonoBehaviour {

    public float Speed, Titl;
    private Vector3 target = new Vector3 (0, 2, 0);
	
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * Speed);
        if (transform.position == target && target.y != 0.1f)
            target.y = 0.1f;
        else if (transform.position == target && target.y == 0.1f)
            target.y = 2.0f;
        transform.Rotate(Vector3.up * Titl);
	}
}
