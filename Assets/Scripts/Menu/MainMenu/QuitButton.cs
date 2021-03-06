using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
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
        Debug.Log("Quit button is clicked");
        Application.Quit(0);
    }
}
