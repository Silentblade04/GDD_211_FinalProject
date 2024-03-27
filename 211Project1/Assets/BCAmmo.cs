using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

namespace weapons
{
public class BCAmmo : MonoBehaviour
{

    public int dmg { get { return damage; } } //allows enemies to get the damage amount

    [SerializeField] protected int damage;
    [SerializeField] protected int rounds; //number of projectiles
    [SerializeField] protected float spread; //how much the rounds deviate
    [SerializeField] protected float recoil; //how long till they can fire again
    
}
}

