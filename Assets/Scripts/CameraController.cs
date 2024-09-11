using UnityEngine;
using Unity.Cinemachine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject overheadCamera;
    public GameObject thirdPersonCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (GlobalVariables.cameraType) {
            case 0:
                overheadCamera.SetActive(true);
                break;
            case 1:
                thirdPersonCamera.SetActive(true);
                break;
            case 2:
                overheadCamera.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
