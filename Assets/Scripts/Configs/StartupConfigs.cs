using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OptpicVR
{
    public class StartupConfigs : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Set the status/navigation background color (set to 0xff000000 to disable)
            ApplicationChrome.statusBarColor = ApplicationChrome.navigationBarColor = 0xffff3300;

            // Makes the status bar and navigation bar visible (default)
            ApplicationChrome.statusBarState = ApplicationChrome.navigationBarState = ApplicationChrome.States.Visible;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
