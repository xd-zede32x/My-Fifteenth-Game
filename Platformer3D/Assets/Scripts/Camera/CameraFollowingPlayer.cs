using UnityEngine;

public class CameraFollowingPlayer : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform _target;
    [SerializeField] private float smoothSpeed = 5f;
    [SerializeField] private float maxSpeed = 10f;

    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        if (_target != null)
        {
            Vector3 desiredPosition = _target.position + offset;
            Vector3 smoothPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed, maxSpeed, Time.deltaTime);
            transform.position = smoothPosition;
        }
    }
}