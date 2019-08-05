using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CirclePropertySetter : MonoBehaviour {

    [SerializeField]
    float speed = 1.0f;

    Material runtimeMaterial;


    void Awake()
    {
        this.runtimeMaterial = Instantiate(GetComponent<Image>().material);
        GetComponent<Image>().material = this.runtimeMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        Rect rect = GetComponent<Image>().rectTransform.rect;
        float halfWidth = rect.width * 0.5f;
        float radius = Mathf.Abs(Mathf.Sin(Time.time * this.speed) * halfWidth);

        this.runtimeMaterial.SetFloat("_Width", rect.width);
        this.runtimeMaterial.SetFloat("_Height", rect.height);
        this.runtimeMaterial.SetFloat("_Radius", radius);
    }
}
