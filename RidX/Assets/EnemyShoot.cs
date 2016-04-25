using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {
    public GameObject bulletPrefab;

    public float fireDelay = 0.50f;
    float cooldownTimer = 0;
    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;

            GameObject BulletGO = (GameObject) Instantiate(bulletPrefab, transform.position, transform.rotation);
            BulletGO.layer = gameObject.layer;
        }
    }
}
