using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShowMessageOnActivate : MonoBehaviour
{
    public GameObject message;
    public Transform hand;
    public Transform head;
    public float spawnDistance = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(ShowMessage);
    }

    // Update is called once per frame
    void Update()
    {
        if(message.activeSelf) {
            message.transform.position = hand.position + new Vector3(hand.forward.x,0,hand.forward.z).normalized * spawnDistance;
            message.transform.LookAt(new Vector3(head.position.x, message.transform.position.y, head.position.z));   
        }

    }

    public void ShowMessage(ActivateEventArgs arg) {
        StopCoroutine(messagePopUp());
        StartCoroutine(messagePopUp());
    }

    IEnumerator messagePopUp()
    {
        message.SetActive(!message.activeSelf);
        message.transform.position = hand.position + new Vector3(hand.forward.x,0,hand.forward.z).normalized * spawnDistance;

        yield return new WaitForSeconds(5);

        message.SetActive(false);
    }
}
