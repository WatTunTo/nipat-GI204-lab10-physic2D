using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
   Vector3 offset= new Vector3(0f, 0f, -10f);
   float smoothTime = 0.25f;
   Vector3 velocity = Vector3.zero;
   [SerializeField] Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }
}
