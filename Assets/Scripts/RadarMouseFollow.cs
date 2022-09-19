using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarMouseFollow : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.y = 0f;
        transform.LookAt(mouseWorldPosition);
    }
}
