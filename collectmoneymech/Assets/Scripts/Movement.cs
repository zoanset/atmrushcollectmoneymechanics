using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float horSpeed;
    float hor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(movementSpeed * Time.deltaTime, hor * horSpeed * Time.deltaTime,0 ));
    }
}
