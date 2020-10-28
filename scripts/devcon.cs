using UnityEngine;

public class devcon : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
        Debug.developerConsoleVisible = true;
        }
    }
}