using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PoolMember : MonoBehaviour
{
    public ProjectileModel.ProjectileDirection Direction;
    
    public void Delete()
    {
        Destroy(gameObject);
    }

    public void SetStatus(bool status)
    {
        gameObject.SetActive(status);
    }

    public void SetPosition(Vector2 position)
    {
        transform.position = position;
    }

}
