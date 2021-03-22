using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DarkMode : MonoBehaviour
{
    [SerializeField] public MenuListAndOptions menuListAndOptions;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Function called when value of slider change
    public void OnChange()
    {
        menuListAndOptions.DarkMode = GetComponent<Toggle>().isOn;
        SetDarkMode();
    }

    public void SetDarkMode()
    {
        GetComponent<Toggle>().isOn = menuListAndOptions.DarkMode;
        if (menuListAndOptions.DarkMode)
        {
            transform.Find("Background").GetComponent<Image>().color = Color.green;
            Debug.Log("Dark mode enabled");
        }
        else
        {
            transform.Find("Background").GetComponent<Image>().color = Color.white;
            Debug.Log("Dark mode disabled");
        }
    }
}
