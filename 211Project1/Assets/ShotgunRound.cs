using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace weapons
{
public class ShotgunRound : BCAmmo
    {
        private void Start()
        {
            damage = 8;
            rounds = 8;
            spread = 1.5f;
            recoil = 2f;
        }
    }
}
