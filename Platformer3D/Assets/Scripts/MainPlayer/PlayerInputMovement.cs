using UnityEngine;

[RequireComponent(typeof(PlayerRotation))]
public class PlayerInputMovement : MonoBehaviour
{
    private const float MaxRotateAngle = 90f;
    private const float MinRotateAngle = -90f;

    private PlayerRotation _rotation;

    private void Start()
    {
        _rotation = GetComponent<PlayerRotation>();
    }

    public void InputMovement(PlayerAnimations playerAnimation, float walkSpeed, float runSpeed)
    {
        bool isRunning = Input.GetKey(KeyCode.LeftShift);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            float rotationY = Input.GetKey(KeyCode.A) ? MinRotateAngle : MaxRotateAngle;
            _rotation.MoveAndSetAnimations(rotationY, playerAnimation, isRunning, isRunning ? runSpeed : walkSpeed);
        }

        else
        {
            playerAnimation.SetAnimations(PlayerAnimationType.Run, false);
            playerAnimation.SetAnimations(PlayerAnimationType.Walk, false);
        }
    }
}