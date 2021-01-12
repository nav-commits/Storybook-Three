using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class trackscript : MonoBehaviour,IPointerDownHandler,IPointerUpHandler{

    public VideoPlayer video;
    Slider tracker;
    bool slide = false;

    // Start is called before the first frame update
    void Start()
    {
        tracker = GetComponent<Slider>();

    }


    public void OnPointerDown(PointerEventData a)
    {
        slide = true;
    }



    public void OnPointerUp(PointerEventData a)
    {
        float frame = (float)tracker.value * (float)video.frameCount;
        video.frame = (long)frame;
        slide = false;
    }




    // Update is called once per frame
    void Update()
    {
        if (!slide)
        {
            tracker.value = (float)video.frame / (float)video.frameCount;
        }
    }
}


