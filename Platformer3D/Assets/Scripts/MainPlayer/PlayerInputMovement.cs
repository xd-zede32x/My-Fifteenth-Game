using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInputMovement : MonoBehaviour
{
    private PlayerMovement _movement;

    private void Start()
    {
        _movement = GetComponent<PlayerMovement>();
    }

    public void InputMovement(PlayerAnimations playerAnimation, float walkSpeed, float runSpeed)
    {
        bool isMoving = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);
        bool isRunning = Input.GetKey(KeyCode.LeftShift);

        if (isMoving)
        {
            if (isRunning)
            {
                playerAnimation.SetRunAnimations(true);
                _movement.Move(runSpeed);
            }

            else
            {
                playerAnimation.SetRunAnimations(false);
                playerAnimation.SetWalkAnimations(true);
                _movement.Move(walkSpeed);
            }
        }

        else
        {
            playerAnimation.SetWalkAnimations(false);
            playerAnimation.SetRunAnimations(false);
        }
    }
}