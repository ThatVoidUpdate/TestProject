using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        FindObjectsOfType<Gun>()[0].AttractingObject = this.gameObject;
    }

    private void OnMouseExit()
    {
        FindObjectsOfType<Gun>()[0].AttractingObject = null;
    }
}
