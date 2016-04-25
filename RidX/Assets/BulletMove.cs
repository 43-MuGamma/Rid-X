using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

    float maxSpeed = 7f;
	// Update is called once per frame
	void Update () {
	    Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);
        pos += transform.rotation * velocity;
        transform.position = pos;
	}
}
