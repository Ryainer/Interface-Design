using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider slider;
    public Image handle;
    public Image sliderBG;

    private Texture2D colorTex;

    private void Awake()
    {
        //this.colorTex = 
    }

    private Texture2D ColorStrip(int density)
    {
        Texture2D huetex = new Texture2D(density, 1);

        Color[] color = new Color[density];

        for(int k =0; k < density; ++k)
        {
            color[k] = Color.HSVToRGB((1.0f * k) / density, 1, 1);
        }

        return huetex;
    }
}
