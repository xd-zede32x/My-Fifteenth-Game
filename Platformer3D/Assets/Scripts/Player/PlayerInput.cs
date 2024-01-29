using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerAnimation _playerAnimation;

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private void Update()
    {
        if (_playerMovement == null || _playerAnimation == null)
            return;

        UserInputWalk(KeyCode.A, KeyCode.D);
        UserInputJump(KeyCode.Space);
    }

    private void UserInputWalk(KeyCode leftKey, KeyCode rightKey)
    {
        bool isWalking = Input.GetKey(leftKey) || Input.GetKey(rightKey);
        _playerMovement.Move(isWalking ? _speed : 0f);

        _playerAnimation.SetWalkAnimation(isWalking);
    }

    private void UserInputJump(KeyCode key)
    {
        bool isGrounded = IsGrounded();
        bool shouldJump = isGrounded && Input.GetKeyDown(key);

        if (shouldJump)
        {
            _playerMovement.Jump(_jumpForce);
            _playerAnimation.SetJumpAnimation(true);
        }

        else
            _playerAnimation.SetJumpAnimation(false);
    }

    private bool IsGrounded()
    {
        float recastDistance = 0.1f;
        RaycastHit hit;

        return Physics.Raycast(transform.position, Vector3.down, out hit, recastDistance);
    }
}