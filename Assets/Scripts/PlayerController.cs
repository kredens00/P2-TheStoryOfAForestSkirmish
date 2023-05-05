using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

    public LayerMask movementMask;
    
    Camera cam;

    PlayerMotor motor;
    void Start () {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }



    void Update(){ 
        if (Input.GetMouseButtonDown(0))
        {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        

        if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
            motor.MoveToPoint(hit.point);
            Debug.Log (" uderzyles" + hit.collider.name + " " + hit.point);
            }
        }
    }   
}
   