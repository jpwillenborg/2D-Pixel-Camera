using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


public class CRTFilter : MonoBehaviour
{
    [SerializeField]
    private Image img;
    private Color tempColor;


    public void AdjustCRT(float value)
    {
        tempColor = img.color;
        tempColor.a = value;
        img.color = tempColor;
    }
}