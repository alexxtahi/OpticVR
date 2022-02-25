using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using OpticVR;

namespace OpticVR 
{
    public class AcuityTest : MonoBehaviour
    {
        static bool isModalConfirmed;
        static public GameObject startModal;
        // Start is called before the first frame update
        void Start()
        {
            isModalConfirmed = false;
            startModal = GameObject.Find("BeforeStartModal");
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void LoadTestScene()
        {
            Debug.Log("Loading the simulator...");
            StartupConfigs.SetStatusBarVisible(false);
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            SceneManager.LoadScene("OpticScene");
        }

        static public void ConfirmStartModal(bool confirmation)
        {
            // Code to start the acuity test simulator
            isModalConfirmed = confirmation;
            startModal.SetActive(!confirmation);
            MouseLook.canLookAround = confirmation;
        }

    }
}