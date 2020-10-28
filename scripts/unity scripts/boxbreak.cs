using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxbreak : MonoBehaviour
{

    public GameObject boxthing;

    public void Destroy()
    {
        Instantiate(boxthing, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
