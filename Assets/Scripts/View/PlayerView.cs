using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerController.Jump();
        }
    }
/// <summary>
/// Для проигрыша анимаций получения урона, смерти или включения дефолтной анимации
/// </summary>
    public void ChangeAnimation() 
    {
        
    }
    
    
}
