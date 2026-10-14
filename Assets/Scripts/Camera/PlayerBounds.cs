using UnityEngine;
using System.Collections;
using Unity.Cinemachine;


public class PlayerBounds : MonoBehaviour
{
    [SerializeField]
    private CinemachineCamera sceneCamera;
    private CinemachinePositionComposer composer;
    private Vector3 initialCameraPosition;
    [SerializeField]
    private GameObject player;
    private Transform initialPlayerTransform;
    private Vector3 respawnPosition;
    private float initialDeadZoneWidth;
    private Rigidbody2D rb2d;

    
    void Start()
    {
        initialCameraPosition = sceneCamera.transform.position;
        composer = sceneCamera.GetComponent<CinemachinePositionComposer>();

        initialPlayerTransform = player.transform;
        respawnPosition = new Vector3(initialPlayerTransform.position.x, 10.0f, initialPlayerTransform.position.z);

        initialDeadZoneWidth = composer.Composition.DeadZone.Size.x;
        rb2d = player.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (player.transform.position.y < -7.0f)
        {
            player.transform.position = respawnPosition;
            sceneCamera.OnTargetObjectWarped(initialPlayerTransform, sceneCamera.transform.position - initialCameraPosition);
            composer.Composition.DeadZone.Size.x = 0.0f;
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            
            StartCoroutine(ResetCamera());
        }
    }

    private IEnumerator ResetCamera()
    {
        yield return new WaitForSeconds(0.5f);
        composer.Composition.DeadZone.Size.x = initialDeadZoneWidth;
        rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}