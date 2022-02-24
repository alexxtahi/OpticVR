using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpticVR {
    public class PageSwiper : MonoBehaviour
    {
        private Animator pageAnimator;

        void Awake()
        {
            pageAnimator = GetComponent<Animator>();
        }

        public void Swipe(string page)
        {
            pageAnimator.SetTrigger(page);
        }
    }
}
