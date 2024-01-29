using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMover : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

        if (_rigidbody == null)
            return;
    }

    public void Move(float movementSpeed)
    {
        float horizontal = Input.GetAxisRaw(Horizontal);
        Vector3 movement = new Vector3(horizontal, 0f);

        _rigidbody.MovePosition(_rigidbody.position + movement * movementSpeed * Time.deltaTime);
    }
}