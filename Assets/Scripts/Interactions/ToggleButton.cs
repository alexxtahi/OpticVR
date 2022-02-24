using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToggleButton : MonoBehaviour
{
    private bool toggleState;
    private TextMeshProUGUI toggleText;

    private Image buttonImage;
    private Image toggleImage;

    public Sprite enableImage;
    public Sprite disableImage;
    // Start is called before the first frame update
    void Start()
    {
        toggleState = false;
        toggleText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
        buttonImage = gameObject.GetComponent<Image>();
        // Get the Icon child of the button
        foreach (Transform child in gameObject.transform)
        {
            if (child.name == "Icon")
            {
                toggleImage = child.GetComponent<Image>();
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toggle()
    {
        toggleState = !toggleState;
        print("Toggle [" + toggleText.text + "] " + toggleState);
        if (toggleState)
        {
            buttonImage.color = new Color32(6, 163, 237, 255);
            toggleImage.sprite = enableImage;
        }
        else
        {
            buttonImage.color = new Color32(51, 51, 51, 255);
            toggleImage.sprite = disableImage;
        }

    }
}
