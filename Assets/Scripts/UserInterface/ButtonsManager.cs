using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonsManager : MonoBehaviour
{
    public GameObject mainScreen;
    
    public GameObject colorBlindButton;
    public GameObject colorBlindButtonText;
    public void SelectSettingsButton()
    {
        mainScreen.SetActive(false);
    }

    public void ChangeColorBlindMode()
    {
        Image img = colorBlindButton.GetComponent<Image>();
        img.color = new Color(0, 0, 0, 192);

        TextMeshPro text = colorBlindButtonText.GetComponent<TextMeshPro>();
        text.color = new Color(255, 255, 255, 0);
    }
}
