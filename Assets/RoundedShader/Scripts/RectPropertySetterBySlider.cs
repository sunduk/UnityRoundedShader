using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RectPropertySetterBySlider : MonoBehaviour {

    Material runtimeMaterial;


    void Awake()
    {
        this.runtimeMaterial = Instantiate(GetComponent<Image>().material);
        GetComponent<Image>().material = this.runtimeMaterial;
    }


    // Update is called once per frame
    void Update()
    {
        float val = GetComponentInChildren<Slider>().value;
        Rect rect = GetComponent<Image>().rectTransform.rect;
        float radius = val * rect.width;

        this.runtimeMaterial.SetFloat("_Width", rect.width);
        this.runtimeMaterial.SetFloat("_Height", rect.height);
        this.runtimeMaterial.SetFloat("_Radius", radius);
    }
}
