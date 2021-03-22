using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuListAndOptions : MonoBehaviour
{
    [SerializeField] public GameObject mainMenu;
    [SerializeField] public GameObject optionMenu;
    [SerializeField] public List<TextMeshProUGUI> listButtonTextToDisplay;
    [SerializeField] public List<TextMeshProUGUI> listTextToDisplay;
    [SerializeField] public Slider fontSizeSlider;
    [SerializeField] public DarkMode darkModeToggle;
    public uint FontSize { get; set; }
    public bool DarkMode { get; set; }

    // On start
    void Start()
    {
        mainMenu.SetActive(true);
        optionMenu.SetActive(false);

        // Load and change fonz size
        FontSize = 20;
        Debug.Log("Set font size to " + FontSize);
        ButtonTextChangeSize();
        TextChangeSize();
        FontSizeSliderChange();
        DarkMode = true;
        darkModeToggle.SetDarkMode();
    }

    // Change all text fonts
    public void ButtonTextChangeSize()
    {
        foreach(TextMeshProUGUI textToDisplay in listButtonTextToDisplay)
        {
            textToDisplay.fontSize = FontSize;
        }
    }
    // Change all text fonts
    public void TextChangeSize()
    {
        foreach (TextMeshProUGUI textToDisplay in listTextToDisplay)
        {
            textToDisplay.fontSize = FontSize;
        }
    }

    // Change value of font size slide
    void FontSizeSliderChange()
    {
        fontSizeSlider.value = FontSize;
    }

}
