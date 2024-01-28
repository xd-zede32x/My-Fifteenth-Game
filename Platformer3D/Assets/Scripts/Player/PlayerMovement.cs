using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(float speed)
    {
        float horizontal = Input.GetAxis(Horizontal);
        Vector3 movement = new Vector3(horizontal, 0f);

        _rigidbody.MovePosition(_rigidbody.position + -movement * speed * Time.deltaTime);
    }

    public void Jump(float jumpForce)
    {
        _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}