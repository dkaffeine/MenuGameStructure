using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    private Button button;

    // Add listener on start
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ClickButton);
    }

    // Action triggered when button is pressed
    public void ClickButton()
    {
        Debug.Log("Start button is clicked");
        SceneManager.LoadScene("MainGame", LoadSceneMode.Single);
    }
}
