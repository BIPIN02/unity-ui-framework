
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public GameObject[] screens;

    private void Awake()
    {
        Instance = this;
    }

    public void OpenScreen(GameObject targetScreen)
    {
        foreach (GameObject screen in screens)
        {
            screen.SetActive(false);
        }

        targetScreen.SetActive(true);
    }
}
