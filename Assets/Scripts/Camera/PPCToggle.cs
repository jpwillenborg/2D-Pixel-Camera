using UnityEngine;
using UnityEngine.Rendering.Universal;


public class PPCToggle : MonoBehaviour
{
    [SerializeField]
    private PixelPerfectCamera ppc;


    public void TogglePPC(bool value)
    {
        ppc.enabled = value;
    }
}