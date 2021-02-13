using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScreen : MonoBehaviour
{
    public VideoPlayer player;
    private void Start()
    {
        player.Prepare();
        player.playOnAwake = false;
    }
    public void Play()
    {
        if(!player.isPlaying)
        {
            player.Play();
        }
    }
    public void Stop()
    {
        if(player.isPlaying)
        {
            player.Stop();
        }
    }
}
