using UnityEngine;
using UnityEngine.Tilemaps;


public class SwitchLights : MonoBehaviour
{
    [SerializeField]
    private GameObject lightGroup;
    [SerializeField]
    private GameObject lampTileMap;
    [SerializeField]
    private GameObject particles;


    public void Switch(bool value)
    {
        lightGroup.SetActive(value);
        lampTileMap.SetActive(value);
        particles.SetActive(value);
    }
}