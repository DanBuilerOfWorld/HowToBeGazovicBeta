using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  
    public void PlayGame()
    {
        // Загрузка следущей сцены
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Выход из игры
    public void ExitGame()
    {
        // Отображение действия скрипта в разделе логирования
        Debug.Log("Игра закрылась");
        Application.Quit();

    }
}
