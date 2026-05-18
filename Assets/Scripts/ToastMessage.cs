
using UnityEngine;
using TMPro;

public class ToastMessage : MonoBehaviour
{
    public TextMeshProUGUI messageText;

    public void ShowMessage(string message)
    {
        gameObject.SetActive(true);

        messageText.text = message;

        CancelInvoke();

        Invoke(nameof(HideMessage), 2f);
    }

    void HideMessage()
    {
        gameObject.SetActive(false);
    }
}
