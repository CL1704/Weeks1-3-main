using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using Vector3 = UnityEngine.Vector3;

public class MouseFollow : MonoBehaviour
{
    public Camera gameCamera;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;
        transform.position = worldMousePosition;
        
        //screen.width
        //screen.height
        //gamecamera.worldMousePosition
    }
}
