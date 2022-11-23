using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button startButton, settingsButton, quitButton;
    public Button backToMainButton;
    public GameObject mainPanel, settingsPanel;

    void Start()
    {
        settingsPanel.SetActive(false);
        mainPanel.SetActive(true);
        startButton.onClick.AddListener(delegate { StartGame(); });
        settingsButton.onClick.AddListener(delegate { GoToSettings(); });
        quitButton.onClick.AddListener(delegate { QuitGame(); });
        backToMainButton.onClick.AddListener(delegate { BackToMainMenu(); });
    }

    private void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    private void GoToSettings()
    {
        settingsPanel.SetActive(true);
        mainPanel.SetActive(false);
    }

    private void QuitGame()
    {
        Debug.Log("Application.quit, will work in real build");
        Application.Quit();
    }

    private void BackToMainMenu()
    {
        settingsPanel.SetActive(false);
        mainPanel.SetActive(true);
    }


}
