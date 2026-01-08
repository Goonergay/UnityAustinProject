using UnityEngine;

public class Keyspin : MonoBehaviour
{

    public float rotationSpeed;

   
    void FixedUpdate()
    {
        this.transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
