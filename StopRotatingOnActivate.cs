using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class StopRotatingOnActivate : MonoBehaviour


{
    public Animator animator;
    public bool CrystalStopMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(StopCrystal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopCrystal(ActivateEventArgs arg)
    {
        if (CrystalStopMoving)
        {
            CrystalStopMoving = false;
            animator.SetBool("CrystalStopMoving", false);
        }
        else
        {
            CrystalStopMoving = true;
            animator.SetBool("CrystalStopMoving", true);
        }
    }
}
