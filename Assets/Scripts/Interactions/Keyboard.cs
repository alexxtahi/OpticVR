using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Keyboard : MonoBehaviour
{
    private Button button;
    private TextMeshProUGUI buttonText;
    private void Awake()
    {
        button = gameObject.GetComponent<Button>();
        buttonText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Button " + buttonText.text + " has been initialized");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PressButton()
    {
        // Call onClick event of this button
        button.onClick.Invoke();
        Debug.Log("button " + buttonText.text + " pressed");
    }
}
