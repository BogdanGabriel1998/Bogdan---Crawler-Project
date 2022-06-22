using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegIdealPosition : MonoBehaviour
{
    private Transform fixedPosition;
    private float distanceBetweenPoints;
    private float minMaxDistance;

    private Vector3 fromPosition;
    private Vector3 toPosition;
    private Vector3 direction;


    [SerializeField] private Transform associatedLeg;
    [SerializeField] private Transform sourcePosition;

    private void Awake()
    {
        fixedPosition = this.transform;
        fromPosition = sourcePosition.transform.position;
        toPosition = fixedPosition.transform.position;
        direction = toPosition - fromPosition;
    }

    private void Update()
    {
        distanceBetweenPoints = Vector3.Distance(fixedPosition.position, associatedLeg.position);
        minMaxDistance = Random.Range(2.0f, 6.0f);

        Ray landingRay = new Ray(sourcePosition.position, direction);
        RaycastHit hit;

        if (Physics.Raycast(landingRay, out hit, 100)) 
        {
            fixedPosition.position = hit.point;

            if (distanceBetweenPoints > minMaxDistance)
            {
                associatedLeg.position = fixedPosition.position;
            }
        }
            
    }
}
