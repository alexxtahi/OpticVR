using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

namespace OpticVR
{
    public class PhoneCamera : MonoBehaviour
    {
        private bool camAvailable;
        private WebCamTexture frontCam;
        private Texture defaultBackground;

        public RawImage background;
        public AspectRatioFitter fit;

        // Start is called before the first frame update
        void Start()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                defaultBackground = background.texture;
                WebCamDevice[] devices = WebCamTexture.devices;
                int multiplier = 4;
                // If no camera available
                if (devices.Length == 0)
                {
                    Debug.Log("No camera detected");
                    camAvailable = false;
                    return;
                }
                // Try to get the front camera in devices list
                for (int i = 0; i < devices.Length; i++)
                {
                    frontCam = new WebCamTexture(devices[i].name, Screen.width*multiplier, Screen.height*multiplier);
                }
                // If no camera has detected
                if (frontCam == null)
                {
                    Debug.Log("Unable to find the front camera");
                    return;
                }
                // Display camera preview
                frontCam.Play();
                background.texture = frontCam;
                camAvailable = true;
            } else
            {
                Debug.Log("This device is not an Android");
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (!camAvailable) return;

            float ratio = (float)frontCam.width / (float)frontCam.height;
            fit.aspectRatio = ratio;

            float scaleY = frontCam.videoVerticallyMirrored ? -1f : 1f;
            background.rectTransform.localScale = new Vector3(1f, scaleY, 1f);

            int orient = -frontCam.videoRotationAngle;
            background.rectTransform.localEulerAngles = new Vector3(0, 0, orient);
        }

        // Method to take a picture with camera
        public void TakePhoto()
        {
            StartCoroutine(BuildImage());
        }

        public IEnumerator BuildImage()  // Start this Coroutine on some button click
        {

            // NOTE - you almost certainly have to do this here:

            yield return new WaitForEndOfFrame();

            // it's a rare case where the Unity doco is pretty clear,
            // http://docs.unity3d.com/ScriptReference/WaitForEndOfFrame.html
            // be sure to scroll down to the SECOND long example on that doco page 

            Texture2D photo = new Texture2D(frontCam.width, frontCam.height);
            photo.SetPixels(frontCam.GetPixels());
            photo.Apply();

            //Encode to a PNG
            byte[] bytes = photo.EncodeToPNG();
            //Write out the PNG. Of course you have to substitute your_path for something sensible
            File.WriteAllBytes("./" + "left_eye.png", bytes);
        }
    }
}
