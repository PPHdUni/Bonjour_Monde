using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouger_Balle : MonoBehaviour {

    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // Ceci est un commentaire
        Vector3 movement = new Vector3(10.0f, 0.0f, 0.0f);
        rb.AddForce(movement);
    }
}
