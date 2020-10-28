using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallfloorplace : MonoBehaviour
{

    public GameObject Wall;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(Wall, transform.position, transform.rotation);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(new Vector3(0,0, Time.deltaTime * 100));
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(new Vector3(0, 0, Time.deltaTime * -100));
        }
    }
}
