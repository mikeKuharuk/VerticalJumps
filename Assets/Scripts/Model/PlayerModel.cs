using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerModel : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    [SerializeField] private float maxSpeed = 10;
    [SerializeField] public int Lifes = 10;

    public Rigidbody2D Rigidbody => rigidbody;
    public float MaxSpeed => maxSpeed;
    


    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
}