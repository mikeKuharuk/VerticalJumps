using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicCanonController : PoolMember
{
    [SerializeField] private CanonModel canonModel;
    [SerializeField] private AmmoPool pool; //todo Ссылку на нужный пул нужно получать в автоматическом режиме, возможно от родительского объекта который размещает пушки

    void OnEnable()
    {
        StartCoroutine(StartShootingSequence());

    }
    
    void SpawnProjectile()
    {
        var ammo = pool.GetAmmo();
        ammo.SetPosition(transform.position);
        ammo.Direction = Direction;
        ammo.SetStatus(true);
    }

    IEnumerator StartShootingSequence()
    {
        yield return new WaitForSeconds(canonModel.ShootRate);
        SpawnProjectile();
        // Сыграть анимацию выстрела
        StartCoroutine(StartShootingSequence());
    }

}
