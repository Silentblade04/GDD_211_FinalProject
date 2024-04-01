using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public Transform spawn;
    public enum GunType {Semi, DoubleBarrel};
    public GunType gunType;



    private void Start()
    {

    }

    public void Shoot()
    {
      
        Ray ray = new Ray(spawn.position, spawn.forward);
        RaycastHit hit;
        float shotDistance = 2000f;
        
        if (Physics.Raycast(ray,out hit, shotDistance))
        {
            shotDistance = hit.distance;
        }
        Debug.DrawRay(ray.origin, ray.direction, Color.red, 1f);
    }

    public void ShootType1()
    {
        if (gunType == GunType.Semi)
        {
            Shoot();
        }
    }
}
