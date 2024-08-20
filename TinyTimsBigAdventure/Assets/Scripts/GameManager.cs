using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    int playerLives = 3;
    bool pausedGame;

    public GameObject player;

    public GameObject pauseScreen;

    // Start is called before the first frame update
    void Start()
    {
        pausedGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }    
    }

    public void GameOver()
    {
        if(playerLives == 0)
        {
            Destroy(player);
        }
    }

    public void PauseGame()
    {
        if (!pausedGame)
        {
            pausedGame = true;
            pauseScreen.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            pausedGame = false;
            pauseScreen.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
