using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Animator animator;
    bool isDoorOpen;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isDoorOpen = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InteractWithDoor()
    {
        if (isDoorOpen) {
            Debug.Log("Close the door");
            animator.SetTrigger("Desactivate");
        }
        else {
            Debug.Log("Open the door");
            animator.SetTrigger("Activate");
        }

        isDoorOpen = !isDoorOpen;
    }
}
