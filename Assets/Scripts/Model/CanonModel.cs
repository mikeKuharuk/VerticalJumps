using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonModel : MonoBehaviour
{
    
    [SerializeField] private float shootRate = 10;
    public ProjectileModel.ProjectileType currentType = ProjectileModel.ProjectileType.Default;

    public float ShootRate => shootRate;
}
