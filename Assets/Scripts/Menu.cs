using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static bool GameIsPaused = true;
    public static bool isDead = false;
    public static bool isWinner = false;
    public GameObject pauseMenuUI;
    public GameObject laserPointer;
    public GameObject startMenuUI;
    public GameObject failMenuUI;
    public GameObject successMenuUI;

    void Start()
    {
        GameIsPaused = true;
        laserPointer.SetActive(true);
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startMenuUI.activeSelf)
        {
            GameIsPaused = true;
            Time.timeScale = 0f;
            laserPointer.SetActive(true);
        }
        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            if (successMenuUI.activeSelf)
            {
                StartGame();
            }
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (Menu.isDead)
        {
            Dead();
        }

        if (Menu.isWinner)
        {
            Success();
        }

        // Testing
        if (Input.GetKeyDown(KeyCode.Space)) {
            StartGame();
        }
    }

    public void StartGame()
    {
        failMenuUI.SetActive(false);
        successMenuUI.SetActive(false);
        startMenuUI.SetActive(false);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        laserPointer.SetActive(false);
    }

    public void Resume()
    {
        failMenuUI.SetActive(false);
        successMenuUI.SetActive(false);
        startMenuUI.SetActive(false);
        pauseMenuUI.SetActive(false);
        laserPointer.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        laserPointer.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    void Dead()
    {
        failMenuUI.SetActive(true);
        laserPointer.SetActive(true);
        Time.timeScale = 0.1f;
        GameIsPaused = true;
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }

    void Success()
    {
        successMenuUI.SetActive(true);
        laserPointer.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
