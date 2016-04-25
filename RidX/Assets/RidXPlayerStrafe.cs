using UnityEngine;
using System.Collections;

public class RidXPlayerStrafe : MonoBehaviour
{

    float maxSpeed = 8.5f; //cap the speed of movement

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update(){
        Vector3 pos = transform.position;
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        else
            pos.x += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        transform.position = pos;
    }
}