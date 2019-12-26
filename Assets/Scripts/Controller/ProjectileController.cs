using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : PoolMember
{
    [SerializeField] private ProjectileModel projectileModel;

    void OnEnable()
    {
        SetDirection();
    }

    void SetDirection() // todo Убрать проверки, передавать вектор как направление, пока заглушка
    {
        if (Direction == ProjectileModel.ProjectileDirection.left)
        {
            transform.eulerAngles = new Vector3(0,0,90);
        }
        else if(Direction == ProjectileModel.ProjectileDirection.right)
        {
            transform.eulerAngles = new Vector3(0,0,-90);
        }
        else
        {
            // todo Установка движения по кривой, или в направлении указаного вектора
        }
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.up*projectileModel.Speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            // Проиграть анимацию уничтожению снаряда
            SetStatus(false);
        }
    }

    /// <summary>
    /// Выключаем объект после того как он покинул зону видимости экрана игрока для экономии памяти и возвращения его в пул
    /// </summary>
    void OnBecameInvisible()
    {
        SetStatus(false);
    }
}
