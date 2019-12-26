using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileModel : MonoBehaviour
{
    [SerializeField] private float projectileSpeed = 10;
    public ProjectileType Type;

    public float Speed => projectileSpeed;
    public enum ProjectileDirection
    {
        left,
        right,
        custom,
    };
    
    /// <summary>
    /// Перечисляем типы снарядов
    /// </summary>
    public enum ProjectileType
    {
        Default,
        Quick,
        Slow,
        Small,
    }
}
