using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class mover : MonoBehaviour
{
    float speed = 0.01f;
    float xMax = 11;
    float xMin = -11;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   
    }
    // Update is called once per frame
    void Update()
    {
       Vector3 moverXPos = transform.position; 
        moverXPos.x = moverXPos.x + speed;
         transform.position = moverXPos;

       if(xMax < transform.position.x) {
        speed *= -1;
       }
       if (xMin > transform.position.x)
        {speed *= -1;
            
        }
    }
}

