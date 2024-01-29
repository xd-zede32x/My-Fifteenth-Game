using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerJump : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

        if (_rigidbody == null)
            return;
    }

    public void Jump(float jumpForce)
    {
        _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}