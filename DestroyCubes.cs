using UnityEngine;
using System.Collections;

public class DestroyCubes : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "flame")
        {
            Destroy(col.gameObject);
        }
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag.Equals("DestrucTrig")){
            Destroy(other.gameObject);
        }
    }
}
