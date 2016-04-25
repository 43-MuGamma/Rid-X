using UnityEngine;
using System.Collections;
//FACES player doesn't chase player
public class PlayerChase : MonoBehaviour {
    public float rotSpeed = 90f;

    Transform player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (player == null){
            //find player
            GameObject found = GameObject.Find("RidXPlayer");
            if(found != null){
                player = found.transform;
            }
        }
        //found or doesn't exist
        if (player == null)
            return; //try next frame

        //player found
        Vector3 dir = player.position - transform.position;
        dir.Normalize();

        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);
	}
}
