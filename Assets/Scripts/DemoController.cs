
using UnityEngine;

public class DemoController : MonoBehaviour
{
    public GameObject homeScreen;
    public GameObject shopScreen;
    public GameObject settingsPopup;

    public ToastMessage toastMessage;

    public void OpenHome()
    {
        UIManager.Instance.OpenScreen(homeScreen);
    }

    public void OpenShop()
    {
        UIManager.Instance.OpenScreen(shopScreen);
    }

    public void OpenSettings()
    {
        PopupManager.Instance.OpenPopup(settingsPopup);
    }

    public void CloseSettings()
    {
        PopupManager.Instance.ClosePopup(settingsPopup);
    }

    public void ShowToast()
    {
        toastMessage.ShowMessage("Coins Added!");
    }
}
