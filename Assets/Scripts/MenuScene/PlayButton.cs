using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayButton : MonoBehaviour
{
    Button button;
    public TMP_Dropdown cameraSelection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(StartGame);
    }

    void StartGame() {
        GlobalVariables.cameraType = cameraSelection.value;
        SceneManager.LoadScene("SampleScene");
    }
}
