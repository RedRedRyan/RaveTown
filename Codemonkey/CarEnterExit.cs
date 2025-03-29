using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarEnterExit : MonoBehaviour
{
    [SerializeField] GameObject human=null;
    [SerializeField] GameObject car= null;
    [SerializeField] KeyCode enterExitkey= KeyCode.E;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(enterExitkey))
        {
            GetOutOfCar();
        }
      
    }
    void GetOutOfCar()
    {
        human.SetActive(true);
        human.transform.position = car.transform.position + car.transform.TransformDirection(Vector3.left);
    }
}
