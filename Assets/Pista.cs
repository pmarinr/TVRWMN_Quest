using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pista : MonoBehaviour
{
    bool inPizarra = false;
    Rigidbody rb;
    public Transform posInicial;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        if (posInicial != null) { 
        transform.position = posInicial.position;
        transform.rotation = posInicial.rotation;
        transform.parent = posInicial;
        }


    }

   

}
