using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class StartBigTeethOnActivate : MonoBehaviour
{
    public Animator animator;
    public bool teethMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(StartTeeth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTeeth(ActivateEventArgs arg)
    {
        if (teethMoving)
        {
            teethMoving = false;
            animator.SetBool("teethMoving", false);
        } else 
        {
            teethMoving = true;
            animator.SetBool("teethMoving", true);
        }
    }
}
