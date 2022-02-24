using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace OpticVR
{
    public class Keyboard : MonoBehaviour
    {
        private Button button;
        private TextMeshProUGUI buttonText;
        private TextMeshProUGUI screenText;
        private void Awake()
        {
            button = gameObject.GetComponent<Button>();
            buttonText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
            screenText = GameObject.Find("KeyboardScreenContent").GetComponent<TextMeshProUGUI>();
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
            Debug.Log("button " + buttonText.text + " pressed");
            // Call onClick event of this button
            //button.onClick.Invoke();
            if (buttonText.text == "Effacer")
                Clear();
            else
                Display();
        }

        public void Display()
        {
            screenText.text = buttonText.text;
        }

        public void Clear()
        {
            screenText.text = "En attente...";
        }

    }
}
