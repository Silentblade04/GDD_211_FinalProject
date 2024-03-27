using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace weapons
{
public class Shooting : MonoBehaviour
{
        [SerializeField] private string ammo;
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {

            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {

            }
        if(Input.GetMouseButton(0))
            {
                shoot();
            }

    }
    private void shoot()
        {
            
        }
}
}

