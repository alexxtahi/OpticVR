using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace OpticVR {
    public class PageSwiper : MonoBehaviour
    {
        static private Animator pageAnimator;
        //private TextMeshProUGUI debugger; //debug

        void Awake()
        {
            pageAnimator = GetComponent<Animator>();
            //debugger = GameObject.Find("Debugger").GetComponent<TextMeshProUGUI>(); //debug
        }

        private void Start()
        {
            //debugger.text = "application path -> " + Application.persistentDataPath; //debug
            //Debug.Log(debugger.text); //debug
        }

        static public void Swipe(string page)
        {
            pageAnimator.SetTrigger(page);
        }
    }
}
