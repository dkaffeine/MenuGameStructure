using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{
    private Button button;
    [SerializeField] public MenuListAndOptions menuListAndOptions;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ClickButton);
    }

    // Action triggered when button is pressed
    public void ClickButton()
    {
        Debug.Log("Close button is clicked");
        menuListAndOptions.mainMenu.SetActive(true);
        menuListAndOptions.optionMenu.SetActive(false);
        menuListAndOptions.SaveData();
    }
}
