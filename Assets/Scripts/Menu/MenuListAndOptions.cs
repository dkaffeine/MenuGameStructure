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
        LoadAndApplyData();
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

    // Save to disk
    public void SaveData()
    {
        Save data = CreateSaveGameObject();
        Options.SaveToDisk(data);
    }

    // Create save game object
    private Save CreateSaveGameObject()
    {
        Save data = new Save();
        data.fontSize = FontSize;
        data.darkMode = DarkMode;
        return data;
    }

    // Load from disk
    public void LoadAndApplyData()
    {
        Save data = Options.LoadFromDisk();
        ApplyData(data);
    }

    // Apply data loaded
    private void ApplyData(Save data)
    {
        FontSize = data.fontSize;
        Debug.Log("Set font size to " + FontSize);
        ButtonTextChangeSize();
        TextChangeSize();
        FontSizeSliderChange();
        DarkMode = data.darkMode;
        darkModeToggle.SetDarkMode();
    }
}
