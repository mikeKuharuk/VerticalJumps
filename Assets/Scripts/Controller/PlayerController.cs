using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerModel))]
[RequireComponent(typeof(PlayerView))]
public class PlayerController : MonoBehaviour
{
    private PlayerModel playerModel;
    private PlayerView playerView;

    void Awake()
    {
        playerModel = GetComponent<PlayerModel>();
    }

    void FixedUpdate()
    {
        ClampSpeed();
    }

    /// <summary>
    /// Ограничиваем скорость персонажа
    /// </summary>
    private void ClampSpeed()
    {
        if (playerModel.Rigidbody.velocity.y > playerModel.MaxSpeed)
        {
            playerModel.Rigidbody.velocity = new Vector2(playerModel.Rigidbody.velocity.x, playerModel.MaxSpeed);
        }
        else if (playerModel.Rigidbody.velocity.y < playerModel.MaxSpeed * -1)
        {
            playerModel.Rigidbody.velocity = new Vector2(playerModel.Rigidbody.velocity.x, playerModel.MaxSpeed * -1);
        }
    }

    public void Jump()
    {
        playerModel.Rigidbody.AddForce(Vector2.up, ForceMode2D.Impulse);
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        HandleDamage();
    }

    /// <summary>
    /// Уменьшаем кол-во жизней, проигрываем анимацию получения урона. Если жизней не осталось, умираем
    /// </summary>
    private void HandleDamage()
    {
        playerModel.Lifes--;
        if (playerModel.Lifes <= 0)
        {
            Die();
        }
    }

    /// <summary>
    /// Включить анимацию смерти, показать UI проигрыша (Пока что просто перезапуск игры)
    /// </summary>
    private void Die()
    {
        Application.LoadLevel(0); //Заглушка из легаси кода, вместо подключения SceneManagment
    }
}