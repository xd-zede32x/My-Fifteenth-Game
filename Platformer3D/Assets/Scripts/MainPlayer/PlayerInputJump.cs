using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerInputJump : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void InputJump(PlayerAnimations playerAnimation, float jumpForce)
    {
        bool shouldJump = IsGrounded() && Input.GetKeyDown(KeyCode.Space);

        if (shouldJump)
        {
            Jump(_rigidbody, jumpForce);
            playerAnimation.SetAnimations(PlayerAnimationType.Jump, true);
        }

        else
        {
            playerAnimation.SetAnimations(PlayerAnimationType.Jump, false);
        }
    }

    private void Jump(Rigidbody rigidbody, float jumpForce)
    {
        rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private bool IsGrounded()
    {
        float recastDistance = 0.1f;
        RaycastHit hit;

        return Physics.Raycast(transform.position, Vector3.down, out hit, recastDistance);
    }
}