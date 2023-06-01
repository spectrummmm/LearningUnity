using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolck : MonoBehaviour
{
    private Rigidbody _rb;

    [SerializeField]  private float speed = 5f;

    [SerializeField] private float angularspeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float z =  Input.GetAxis("Vertical"),
            y = Input.GetAxis("Horizontal");
        _rb.AddRelativeForce(speed * ( -z ) ,0f, 0f);
        _rb.AddRelativeTorque(0f ,y*angularspeed,0f);
    }
}
    