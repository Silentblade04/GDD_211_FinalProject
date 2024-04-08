using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private InputHandler inputHandlerScript;
    [SerializeField] private PlayerAnimator animator;
    [SerializeField] public PlayerController controller;
    [SerializeField] public float velocityX = 0f;
    [SerializeField] public float velocityZ = 0f;
    [SerializeField] private Vector3 mousePos;
    [SerializeField] private Vector3 playerDirect;
    [SerializeField] private Vector3 goalDirection;       
    [SerializeField] private Camera cam;
    private Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        inputHandlerScript = GetComponent<InputHandler>();
        cam = Camera.main;
        controller = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Finding Mouse Position
        mousePos = Input.mousePosition;
        controller.GetComponent<PlayerController>().GetMousePosition();

        var (success, position) = controller.GetComponent<PlayerController>().GetMousePosition(); ;
        if (success)
        {
            // Calculate the direction
            targetPosition = position - transform.position;


            // Ignore the height difference.
            targetPosition.y = 0;

        }

            //Finding Player Movement
            playerDirect = new Vector3(inputHandlerScript.InputVector.x, 0, inputHandlerScript.InputVector.y);
        goalDirection = targetPosition.normalized - playerDirect.normalized;

        velocityX = goalDirection.x;
        velocityZ = goalDirection.y;
        if (Input.GetKeyDown(KeyCode.K)) {

            Debug.Log(controller.GetComponent<PlayerController>().GetMousePosition());
        }
    }
}
