using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public GameObject topDownText;
    public GameObject centerFromEarthText;
    public GameObject differentSpectrumViewText;
    public GameObject artisticImpressionText;
    public GameObject topDownPlane;
    public GameObject earthViewPlane;
    public GameObject differentSpectrumPlane;
    private bool isTopTextActive;
    private bool isEarthTextActive;
    private bool isSpectrumTextActive;

    // Start is called before the first frame update
    void Start()
    {
        centerFromEarthText.SetActive(false);
        differentSpectrumViewText.SetActive(false);
        artisticImpressionText.SetActive(false);
        isTopTextActive = true;
        isEarthTextActive = false;
        isSpectrumTextActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!topDownPlane.activeSelf && isTopTextActive)
        {
            topDownText.SetActive(false);
            isTopTextActive = false;
            centerFromEarthText.SetActive(true);
            isEarthTextActive = true;
        }
        else if (!earthViewPlane.activeSelf && isEarthTextActive)
        {
            centerFromEarthText.SetActive(false);
            isEarthTextActive = false;
            differentSpectrumViewText.SetActive(true);
            isSpectrumTextActive = true;
        }
        else if(!differentSpectrumPlane.activeSelf && isSpectrumTextActive)
        {
            differentSpectrumPlane.SetActive(false);
            isSpectrumTextActive = false;
            artisticImpressionText.SetActive(true);
        }
    }
}
