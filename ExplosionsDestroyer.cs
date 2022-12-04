using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionsDestroyer : MonoBehaviour
{
    // Длительность взрыва на сцене
    public float timeToDestroy;
    // Скрипт запустится один раз при старте


    void Start()
    {
        // Удаление взрыва из сцены
        Destroy(gameObject, timeToDestroy);
        
    }


}
