using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    // Звук монет
    public AudioClip CoinSound;
    // Ссылка на объект с текстом
    public GameObject TextObject;
    // Ссылка на текстовой компонент
    Text textComponent;
    // Количество собранных монет (переменная)
    public int сoin;


    // Еденичный запуск скрипта
    void Start()
    {
        //Ссылка на текствой компонент

        textComponent = TextObject.GetComponent<Text>(); 
        
    }







    // Запуск при поподании в триггер
    void OnTriggerEnter2D(Collider2D other)
    {
        // Проверка попал ли объект в тег Coin
        if (other.tag == "Сoin")
        {
            // Счётчик монет
            сoin = сoin + 1;
            textComponent.text = сoin.ToString();
            // Проигрыватель звука монет
            AudioSource.PlayClipAtPoint(CoinSound, transform.position);
            // Удаление монет со сцены
            Destroy(other.gameObject);
        }
    }
}
