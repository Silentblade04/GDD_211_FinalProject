using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulse : MonoBehaviour
{

    public GameObject projectilePrefab;
    public Transform firePoint;
    public float projectileSpeed = 10f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) // Change to any desired input key
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = firePoint.right * projectileSpeed; // Assuming the projectile moves along the object's forward direction
        }
        else
        {
            Debug.LogError("Rigidbody not found on projectile prefab.");
        }
    }

}


