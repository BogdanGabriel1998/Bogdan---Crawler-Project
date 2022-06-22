using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererLegs : MonoBehaviour
{
    
    private Transform legStartingPosition;

    [SerializeField] private Transform legFootPosition;
    [SerializeField] private LineRenderer lineRenderer;


    private void Awake()
    {
        legStartingPosition = this.transform;
        lineRenderer.positionCount = 2;
    }

    private void Update()
    {
        lineRenderer.SetPosition(0, legStartingPosition.position);
        lineRenderer.SetPosition(1, legFootPosition.position);
    }


}
