using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GIF_Animator : MonoBehaviour
{
    public Sprite[] animatedImages;
    private Image imageToAnimate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        imageToAnimate = GetComponent<Image>();
        imageToAnimate.sprite = animatedImages[(int)(Time.time*10)%animatedImages.Length];

    }
}
