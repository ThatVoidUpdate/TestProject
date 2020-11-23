using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float delay;

    float currentTime;

    public GameObject BulletPrefab;

    public GameObject AttractingObject;
    public bool IsAttracting;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > delay)
        {
            if (Input.GetMouseButton(0))
            {
                currentTime -= delay;
                SpawnBullet();
            }
        }

        if (Input.GetMouseButton(1) && AttractingObject != null)
        {
            IsAttracting = true;
        }
        else
        {
            IsAttracting = false;
        }
        
    }

    void SpawnBullet()
    {
        Instantiate(BulletPrefab, transform.position + transform.forward, Quaternion.identity).GetComponent<Transform>().forward = transform.forward;
    }
}
