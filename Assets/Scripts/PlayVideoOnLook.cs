using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideoOnLook : MonoBehaviour
{
    public Camera cam;
    private VideoScreen activeScreen = null;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        ScanForVideos();
    }
    private void ScanForVideos()
    {
        RaycastHit ray;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out ray))
        {
            if(ray.transform != null)
            {
                VideoScreen hit = ray.transform.GetComponent<VideoScreen>();
                if (hit != null)
                {
                    if (activeScreen == null)
                    {
                        hit.Play();
                        activeScreen = hit;
                    }
                }
            }
        }
        else
        {
            if (activeScreen != null)
            {
                activeScreen.Stop();
                activeScreen = null;
            }
        }
    }
}
