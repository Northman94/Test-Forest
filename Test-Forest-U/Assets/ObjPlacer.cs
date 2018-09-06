using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPlacer : MonoBehaviour 
{

    private Grid grid;

    private void Awake()
    {
        grid = FindObjectOfType<Grid>( );
    }



    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit rayHitInfo;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out rayHitInfo))
            {
                ObjPlacement(rayHitInfo.point);
            }
        }
    }



         void ObjPlacement (Vector3 nearPoint)
        {
            var finalPosition = grid.GetNearestPointOnGreed(nearPoint);

            GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = finalPosition;
        }


   


}
