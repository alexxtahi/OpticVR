using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace OpticVR {
    public class PageSwiper : MonoBehaviour
    {
        private Animator pageAnimator;
        private TextMeshProUGUI debugger;

        void Awake()
        {
            pageAnimator = GetComponent<Animator>();
            debugger = GameObject.Find("Debugger").GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            debugger.text = "application path -> " + Application.persistentDataPath;
            Debug.Log(debugger.text);

        }

        public void Swipe(string page)
        {
            pageAnimator.SetTrigger(page);
        }
    }
}
