using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Библиотека для работы со сценами
using UnityEngine.SceneManagement;

public class DeadEndController : MonoBehaviour
{
    //Запуск при поподании в триггер
    void OnTriggerEnter2D(Collider2D other)
    {
        // Проверка тега Player
        if(other.tag == "Player")
        {
            // Посмотреть название текущей сцены и загрузкой
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}