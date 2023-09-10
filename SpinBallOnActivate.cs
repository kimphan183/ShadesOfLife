using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SpinBallOnActivate : MonoBehaviour
{
    public bool isSpinning = false;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(SpinBall);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpinBall(ActivateEventArgs arg) {
        if (isSpinning) {
            isSpinning = false;
            animator.SetBool("spinning", false);
        } else {
            isSpinning = true;
            animator.SetBool("spinning", true);
        }
    }
}
