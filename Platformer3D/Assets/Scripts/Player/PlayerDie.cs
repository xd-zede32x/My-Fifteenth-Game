using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    private readonly int OpenPanel = Animator.StringToHash(nameof(OpenPanel));
    private readonly int ExitPanel = Animator.StringToHash(nameof(ExitPanel));

    [SerializeField] private GameObject _panelLose;
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private StartMenu _startMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Thorns thorns))
        {
            Open();
            _panelLose.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void Open()
    {

    }

    private void Exit()
    {

    }
}