using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuGame : MonoBehaviour
{
    private const float MaxAlpha = 1;
    private const float MinAlpha = 0;
        
    [SerializeField] private GameObject _panel;
    [SerializeField] private CanvasGroup _canvasGroup;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            OpenPanel();
    }

    public void OpenPanel()
    {
        SetActivePanel(MaxAlpha, true);

        SetDefaultCursorState(CursorLockMode.None, true);
    }

    public void HidePanel()
    {
        SetActivePanel(MinAlpha, false);

        SetDefaultCursorState(CursorLockMode.Locked, false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }

    private void SetActivePanel(float alpha, bool isActive)
    {
        _canvasGroup.alpha = alpha;
        _panel.SetActive(isActive);
    }

    private void SetDefaultCursorState(CursorLockMode lockMode, bool isActiveCursor)
    {
        Cursor.lockState = lockMode;
        Cursor.visible = isActiveCursor;
    }
}