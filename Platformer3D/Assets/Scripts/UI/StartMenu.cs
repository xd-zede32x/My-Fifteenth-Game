using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class StartMenu : MonoBehaviour
{
    private readonly int OpenPanel = Animator.StringToHash(nameof(OpenPanel));
    private readonly int ExitPanel = Animator.StringToHash(nameof(ExitPanel));

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();

        if (_animator == null)
            return;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && SceneManager.GetActiveScene().buildIndex == 0)
            _animator.SetTrigger(ExitPanel);
    }

    public void Open()
    {
        _animator.SetTrigger(OpenPanel);
    }

    public void Exit()
    {
        _animator.SetTrigger(ExitPanel);
        Application.Quit();
    }
}