using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    [SerializeField]
    private float speed;
    private Vector3 _moveDirection;
    // Start is called before the first frame update
   
    //Rigidbody rb;
    void Start()
    {
        //rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //   _horizontal = Input.GetAxis("Horizontal");
        // _vertical = Input.GetAxis("Vertical");
        Direction();
    }

    void Direction()
    {
        if (playerData.Instance._stop == false)
        {
            _moveDirection = new Vector3(InputManager.Instance().horizontalInputValue * playerData.Instance._swipeSpeed, 0, playerData.Instance._moveSpeed);

            transform.Translate(_moveDirection * Time.deltaTime);
        }
    }
}
