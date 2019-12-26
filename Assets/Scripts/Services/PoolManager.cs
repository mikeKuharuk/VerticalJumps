using System;
using UnityEngine;

public abstract class PoolManager : MonoBehaviour
{
    [SerializeField] protected PoolMember[] objectsPool; // todo Объекты должны загружаться при старте сцены, сейчас временно в ручном режиме

    void Awake()
    {
        LoadDefaultPreset();
        DisableAllObjects();
    }
    
    /// <summary>
    /// Выключаем все ранее загруженные объекты
    /// </summary>
    public void DisableAllObjects()
    {
        foreach (var item in objectsPool)
        {
            item.SetStatus(false);
        }
    }

    /// <summary>
    /// Загружаем базовый набор объектов 
    /// </summary>
    protected abstract void LoadDefaultPreset(); //todo Пресет должен быть в ScriptableObject 

    /// <summary>
    /// Создаем новый объект из ресурсов и добавляем его в пул
    /// </summary>
    protected abstract void InstantiateNewObject();

    /// <summary>
    /// Увеличиваем размер пула в случае нехватки мест
    /// </summary>
    protected void IncreasePoolSize(int newSize)
    {
        Array.Resize(ref objectsPool,newSize);
    }
}