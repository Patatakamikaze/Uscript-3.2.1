using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsulemovement : MonoBehaviour
{
    public Vector3 direccion;
    public float speed;
 

    
    void Update()
    {
        direccion = ClampVector3(direccion);
        transform.Translate (direccion * (speed * Time.deltaTime));
    }
    public static Vector3 ClampVector3(Vector3 target)
    {
        float ClampedX = Mathf.Clamp(target.x, -1f, 1f);
        float ClampedY = Mathf.Clamp(target.y, -1f, 1f);
        float ClampedZ = Mathf.Clamp(target.z, -1f, 1f);
        Vector3 result = new Vector3(ClampedX, ClampedY, ClampedZ);
        return result;
    }
}
