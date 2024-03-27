using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using weapons;



namespace weapons
{
public class RifleRound : BCAmmo
{
    private void Start()
    {
        damage = 50;
        rounds = 1;
        spread = 0.02f;
        recoil = 1.25f;
    }
}
}

