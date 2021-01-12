using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class trackscript : MonoBehaviour
{
    public VideoPlayer video;
    Slider tracker;


    // Start is called before the first frame update
    void Start()
    {
        tracker = GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {
        tracker.value = (float)video.frame / (float)video.frameCount;
    }
}


