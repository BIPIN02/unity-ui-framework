
using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    public GameObject loadingPanel;

    public void ShowLoading()
    {
        loadingPanel.SetActive(true);
    }

    public void HideLoading()
    {
        loadingPanel.SetActive(false);
    }
}
