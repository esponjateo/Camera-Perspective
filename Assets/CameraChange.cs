using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject FirstCam;
    public GameObject Thirdcam;

    public int CamMode;

    void Update()
    {
        if (Input.GetButtonDown("Camera"))
        {
            if (CamMode == 1)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            }
            StartCoroutine(SwitchCamera()); // Call the new method here
        }
    }

    IEnumerator SwitchCamera()
    {
        yield return new WaitForSeconds(0.01f); // Add a delay for effect

        if (CamMode == 0)
        {
            FirstCam.SetActive(false);
            Thirdcam.SetActive(true);
        }
        else if (CamMode == 1)
        {
            FirstCam.SetActive(true);
            Thirdcam.SetActive(false);
        }
    }
}
