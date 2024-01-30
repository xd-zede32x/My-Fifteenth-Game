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
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                playerAnimation.SetRunAnimation(true);
                _movement.Move(runSpeed);
            }

            else
            {
                playerAnimation.SetRunAnimation(false);
                playerAnimation.SetWalkAnimation(true);
                _movement.Move(walkSpeed);
            }
        }

        else
        {
            playerAnimation.SetWalkAnimation(false);
            playerAnimation.SetRunAnimation(false);
        }
    }
}