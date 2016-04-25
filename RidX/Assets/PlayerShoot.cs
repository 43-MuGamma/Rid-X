using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
    public GameObject bulletPrefab;

    public float fireDelay = 0.000001f;
    float cooldownTimer = 0;
	// Update is called once per frame
	void Update () {
        cooldownTimer -= Time.deltaTime;
        if (Input.GetButton("Fire1") && cooldownTimer <= 0){
            cooldownTimer = fireDelay;

            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
	}
}
