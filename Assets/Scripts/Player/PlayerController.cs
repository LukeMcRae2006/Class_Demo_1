using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{




    //Roaming Attributes and variables
    private bool isInAttackMode = true;
    [SerializeField] private InputActionReference moveAction;
    [SerializeField] private InputActionReference jumpAction;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float playerSpeed;
    private float moveX;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {



        moveX = moveAction.action.ReadValue<Vector2>().x;






    }

    void FixedUpdate()
    {
        //Since we are using rigidbody, move in fixed updatee

        rb.linearVelocity = new Vector2(moveX * playerSpeed, rb.linearVelocity.y);




    }



}
