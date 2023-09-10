using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShowLightOnActivate : MonoBehaviour
{
    public GameObject light;
    AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(ShowLight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowLight(ActivateEventArgs arg) {
        sound.Play();
        light.SetActive(!light.activeSelf);
    }
}
