using UnityEngine;

public class PlayerSitDown : MonoBehaviour
{
    public void InputSitDown(PlayerAnimations playerAnimation)
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
            SetDown(playerAnimation, true);

        else
            SetDown(playerAnimation, false);
    }

    private void SetDown(PlayerAnimations animations, bool isPlay)
    {
        animations.SetDownAnimations(isPlay);
    }
}