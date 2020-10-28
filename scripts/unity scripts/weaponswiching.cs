using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponswiching : MonoBehaviour
{
    public GameObject Gun1;
    public GameObject Gun2;
    public GameObject wall;
    public GameObject floor;
    // Start is called before the first frame update
    void Start()
    {
        Gun1.SetActive(true);
        Gun2.SetActive(false);
        wall.SetActive(false);
        floor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Gun1.SetActive(true);
            Gun2.SetActive(false);
            wall.SetActive(false);
            floor.SetActive(false);
        }
        if (Input.GetKeyDown("2"))
        {
            Gun1.SetActive(false);
            Gun2.SetActive(true);
            wall.SetActive(false);
            floor.SetActive(false);
        }
        if (Input.GetKeyDown("3"))
        {
            Gun1.SetActive(false);
            Gun2.SetActive(false);
            wall.SetActive(true);
            floor.SetActive(false);
        }
        if (Input.GetKeyDown("4"))
        {
            Gun1.SetActive(false);
            Gun2.SetActive(false);
            wall.SetActive(false);
            floor.SetActive(true);
        }
    }
}
