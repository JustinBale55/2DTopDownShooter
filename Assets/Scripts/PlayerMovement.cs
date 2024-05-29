using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	InputActionAsset inputActions;
	[SerializeField]
	Rigidbody rb;

	private InputAction moveAction;
	private Vector2 moveValue;

	private void Awake()
	{
		moveAction = inputActions.FindActionMap("Gameplay").FindAction("Movement");
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveValue = moveAction.ReadValue<Vector2>();
		Debug.Log(moveValue);
    }
}