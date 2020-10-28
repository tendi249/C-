using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAim : MonoBehaviour
{

    public float SmoothSpeed = 10f;

    public Vector3 AimDownSight;
    // -0.3, -1.56, 0
    public Vector3 hipfire;
    // 0, -1.56, 0


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            transform.localPosition = Vector3.Slerp(transform.localPosition, AimDownSight, SmoothSpeed * Time.deltaTime);
        }
        if(Input.GetMouseButtonUp(1))
        {
            transform.localPosition = hipfire;
        }
    }
}
