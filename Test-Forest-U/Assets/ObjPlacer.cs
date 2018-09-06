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
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit rayHitInfo;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out rayHitInfo))
            {
                ObjPlacement(rayHitInfo.point);
            }
        }
    }



        private void ObjPlacement (Vector3 clickPoint)
        {
            var finalPosition = grid.GetNearestPointOnGreed(clickPoint);

        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = finalPosition;
        }


}
