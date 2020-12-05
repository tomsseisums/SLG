using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIController : MonoBehaviour
{
    [SerializeField]
    private Button startButton;

    [SerializeField]
    private string gameSceneName;

    private void OnEnable()
    {
        startButton.onClick.AddListener(LoadGame);
    }

    private void OnDisable()
    {
        startButton.onClick.RemoveListener(LoadGame);
    }

    private void LoadGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}
