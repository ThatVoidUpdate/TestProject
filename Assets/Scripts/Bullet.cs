using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    public float speed;

    Vector3 Direction;

    // Start is called before the first frame update
    void Start()
    {
        Direction = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = Direction * speed;

        if (FindObjectsOfType<Gun>()[0].IsAttracting)
        {
            Direction = (FindObjectsOfType<Gun>()[0].AttractingObject.transform.position - transform.position).normalized;
        }
    }
}
