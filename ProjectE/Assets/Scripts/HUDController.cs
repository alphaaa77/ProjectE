using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour
{
    public Button mainMenuButton;

    void Start()
    {
        mainMenuButton.onClick.AddListener(delegate { BackToMainMenu(); });
    }

    private void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
