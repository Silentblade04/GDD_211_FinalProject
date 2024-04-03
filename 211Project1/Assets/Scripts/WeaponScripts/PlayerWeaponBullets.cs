using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponBullets : MonoBehaviour
{
    public float bulletSpeed = 1f;

    private void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    private void FixedUpdate()
    {
        transform.position += transform.forward * bulletSpeed;

    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
