using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour
{
    [SerializeField]
    private Button quitButton;

    [SerializeField]
    private string menuSceneName;

    private void OnEnable()
    {
        quitButton.onClick.AddListener(QuitGame);
    }

    private void OnDisable()
    {
        quitButton.onClick.RemoveListener(QuitGame);
    }

    private void QuitGame()
    {
        SceneManager.LoadScene(menuSceneName);
    }
}
