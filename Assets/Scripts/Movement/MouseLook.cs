using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpticVR
{
    public class MouseLook : MonoBehaviour
    {
        // Properties
        public float mouseSensitivity = 100f;
        public Transform playerBody;

        float xRotation = 0f;
        static public bool canLookAround = true;

        /// <summary>
        /// Start is called before the first frame update
        /// </summary>
        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        /// <summary>
        /// Update is called once per frame
        /// </summary>
        void Update()
        {
            if (canLookAround)
            {
                // Get the mouse position
                float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
                float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
                // Define rotation limits
                xRotation -= mouseY;
                xRotation = Mathf.Clamp(xRotation, -90f, 90f);
                transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
                // Rotate the player view
                playerBody.Rotate(Vector3.up * mouseX);
            }
        }
    }
}
