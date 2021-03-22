using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionButton : MonoBehaviour
{

    private Button button;
    [SerializeField] public MenuListAndOptions menuListAndOptions;

    // Add listener on start
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ClickButton);
    }

    // Action triggered when button is pressed
    public void ClickButton()
    {
        Debug.Log("Option button is clicked");
        menuListAndOptions.mainMenu.SetActive(false);
        menuListAndOptions.optionMenu.SetActive(true);
    }
}
