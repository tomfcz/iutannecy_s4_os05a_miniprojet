using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    [SerializeField] Transform playercamera = null;
    [SerializeField] float mouseSensitivity = 3.5f;
    [SerializeField] float walkSpeed = 6.0f;

    [SerializeField] bool lockCursor = true;


    float cameraPitch = 0.0f;
    CharacterController controller = null;
    
    void Start()
    {
        //controller = GetComponent<CharacterController>();
        if(lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMouseLook();   
        //UpdateMovement();
    }

    void  UpdateMouseLook()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        
        cameraPitch -= mouseDelta.y * mouseSensitivity;
        
        cameraPitch = Mathf.Clamp(cameraPitch, -50.0f, 50.0f );
        
        playercamera.localEulerAngles = Vector3.right * cameraPitch;


        transform.Rotate(Vector3.up * mouseDelta.x * mouseSensitivity);
    }

    void UpdateMovement()
    {
        Vector2 inputDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        inputDir.Normalize();

        Vector3 velocity = (transform.forward * inputDir.y + transform.right * inputDir.x) * walkSpeed;

        controller.Move(velocity * Time.deltaTime);
    }
}
