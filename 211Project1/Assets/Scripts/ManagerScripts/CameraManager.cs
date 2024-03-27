using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    [SerializeField] public GameObject playerPosition;
    [SerializeField] public Vector3 targetCameraPosition;

    private void Update()
    {
        targetCameraPosition = new Vector3(playerPosition.gameObject.transform.position.x - 5 ,transform.position.y, playerPosition.gameObject.transform.position.z - 5);
        transform.position = targetCameraPosition;
    }
}
