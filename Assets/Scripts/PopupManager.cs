
using UnityEngine;

public class PopupManager : MonoBehaviour
{
    public static PopupManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void OpenPopup(GameObject popup)
    {
        popup.SetActive(true);
    }

    public void ClosePopup(GameObject popup)
    {
        popup.SetActive(false);
    }
}
