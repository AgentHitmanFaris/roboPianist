using UnityEngine;

public class MySmoothCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = -Vector3.forward;
    public float moveSpeed = 1.0f;
    public float rotSpeed = 360.0f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 wantedPos = target.position + target.rotation * offset;

        transform.position = Vector3.Lerp(transform.position, wantedPos, Time.deltaTime * moveSpeed);

        if (target.position != transform.position)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), Time.deltaTime * rotSpeed);
        }
    }
}
