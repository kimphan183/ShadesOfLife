using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LightsOn : MonoBehaviour
{
    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(ShowLight);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowLight(ActivateEventArgs arg)
    {
        light.SetActive(!light.activeSelf);
    }
}
