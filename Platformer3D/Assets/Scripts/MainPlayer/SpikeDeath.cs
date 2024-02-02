using UnityEngine;
using System.Collections;

public class SpikeDeath : MonoBehaviour
{
    private const float PlayerLifeTime = 5f;
    private const float PanelWaitingTime = 3f;

    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private GameObject _lossPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerAnimations animations))
        {
            animations.SetAnimations(PlayerAnimationType.Die, true);

            StartCoroutine(OpenPanel());
            Destroy(gameObject, PlayerLifeTime);
        }
    }

    private IEnumerator OpenPanel()
    {
        yield return new WaitForSeconds(PanelWaitingTime);
        OpenLossPanel();
    }

    private void OpenLossPanel()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        _lossPanel.SetActive(true);
        _canvasGroup.alpha = 1;
    }
}