using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag.Equals("DeCo")){
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag.Equals("DeTri")){
            Destroy(other.gameObject);
        }
    }
}
