using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public Transform toFollow;
   public float zOff;
   public float yOff;
   public float slew;
   private RaycastHit hit;
   private Vector3 fromTo;
    
    void Update()
    {
        Vector3 newPosition = toFollow.position - toFollow.forward *zOff;
        newPosition.y += yOff;
        fromTo = newPosition - toFollow.position;

        if (Physics.Raycast(toFollow.position, fromTo, out hit, fromTo.magnitude))
        {
            this.transform.position = hit.point;
        }
        else
        {
            this.transform.position = newPosition;
        } 

       
        Quaternion newRotation = Quaternion.LookRotation(toFollow.position - this.transform.position);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newRotation, slew);
    }
}

