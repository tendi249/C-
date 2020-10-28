using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwthing : MonoBehaviour
{
    public float throwforce = 40f;
    public GameObject Grenadeprefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            ThrowBomb();
        }
    }

    void ThrowBomb()
    {
        GameObject grenad = Instantiate(Grenadeprefab, transform.position, transform.rotation);
        Rigidbody rb = grenad.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwforce, ForceMode.VelocityChange);
    }
}
