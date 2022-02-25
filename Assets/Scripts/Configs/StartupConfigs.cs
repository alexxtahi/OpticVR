using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpticVR
{
    public class StartupConfigs : MonoBehaviour
    {
        private void Awake()
        {
            SetStatusBarVisible(true);
        }

        static public void SetStatusBarVisible(bool statusbarState)
        {
            if (statusbarState)
            {
                // Set the status/navigation background color (set to 0xff000000 to disable)
                ApplicationChrome.statusBarColor = ApplicationChrome.navigationBarColor = 0x15151500; // Black background color used in the app
                // Makes the status bar and navigation bar visible (default)
                ApplicationChrome.statusBarState = ApplicationChrome.navigationBarState = ApplicationChrome.States.Visible;
            }
            else
            {
                ApplicationChrome.statusBarState = ApplicationChrome.navigationBarState = ApplicationChrome.States.Hidden;
            }
        }

    }
}
