using UnityEngine;
using UnityEngine.Events;

public class WinScreen : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onShowWinScreen;
    [SerializeField]
    private TextMesh[] textMeshes;
    [SerializeField]
    private GameObject nextLeveButton;
    [SerializeField]
    private GameObject quitButton;
    [SerializeField]
    private LevelManager levelManager;
    [SerializeField]
    private GameObject[] screenassets;
    private void Awake()
    {
        ShowScreenAssets(false);
    }
    public void ShowWinScreen()
    {
        ShowScreenAssets(true);
        onShowWinScreen?.Invoke();
        ChangeTextMeshes("You\nwin!");
        levelManager.Nextlevel();
        nextLeveButton.SetActive(!levelManager.IsPastLastLevel);
        quitButton.SetActive(true);
    }
    public void ShowLoseScreen()
    {
        ShowScreenAssets(true);
        onShowWinScreen?.Invoke();
        ChangeTextMeshes("You\nLose");
        nextLeveButton.SetActive(true);
        quitButton.SetActive(true);
    }
    private void ChangeTextMeshes(string text)
    {
        foreach (TextMesh textMesh in textMeshes)
        {
            textMesh.text = text;
        }
    }
    private void ShowScreenAssets(bool show)
    {
        foreach (GameObject asset in screenassets)
        {
            asset.SetActive(show);
        }
    }
}
