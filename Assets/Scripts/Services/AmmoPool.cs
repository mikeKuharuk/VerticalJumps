using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Для каждого типа снарядов должен быть свой пул для того что бы всё время не приводить типы к нужным и избежать лишних сравнений
/// </summary>
public class AmmoPool : PoolManager
{
    protected override void LoadDefaultPreset()
    {

    }

    protected override void InstantiateNewObject()
    {

    }

    public PoolMember GetAmmo()
    {
        foreach (var VARIABLE in objectsPool)
        {
            if (VARIABLE.gameObject.activeSelf == false)
            {
                return VARIABLE;
            }
        }

        return null;
    }


}