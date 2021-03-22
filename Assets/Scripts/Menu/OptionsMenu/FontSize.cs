using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontSize : MonoBehaviour
{

    [SerializeField] public MenuListAndOptions menuListAndOptions;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Function called when value of slider change
    public void OnChange()
    {
        menuListAndOptions.FontSize = (uint)GetComponent<Slider>().value;
        menuListAndOptions.ButtonTextChangeSize();
        menuListAndOptions.TextChangeSize();
        Debug.Log("Font size changed to: " + menuListAndOptions.FontSize);
    }

}
