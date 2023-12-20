using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

    
{
    CharacterController characterController;
    [SerializeField] private float playerspeed;
    [SerializeField] private Camera followCamera;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement() 
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float vericalInput = Input.GetAxis("vertical");

        Vector3 movementInput = Quaternion.Euler(0,followCamera.transform.eulerAngles.y,0) * new Vector3 (horizontalInput,0,vericalInput);
        characterController.Move(movementInput * playerspeed * Time.deltaTime);
    }
}
