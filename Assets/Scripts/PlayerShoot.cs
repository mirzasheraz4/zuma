using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject[] BallArray;
    public GameObject FirePoint;
    public Camera Cam;
    public GameObject PlayerFace;
    void Start()
    {
        
    }
    void Update()
    {
        PlayerRotation();
        Shoot();
    }
    private void PlayerRotation()
    {
        Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(hit.point); 
            transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
        }
    }
    private void Shoot()
    {
        int index = Random.Range(0, BallArray.Length);
        //Debug.Log(index);
        if (Input.GetMouseButtonDown(0))
        {
            if (index == 0)
            {
                PlayerFace.GetComponent<MeshRenderer>().material.color = Color.blue;
                //Debug.Log("Ball color is : BLUE" + index);
            }
            if (index == 1)
            {
                PlayerFace.GetComponent<MeshRenderer>().material.color = Color.green;
               // Debug.Log("Ball color is : GREEN" + index);
            }
            if (index == 2)
            {
                PlayerFace.GetComponent<MeshRenderer>().material.color = Color.yellow;
               // Debug.Log("Ball color is : Yello" + index);
            }
            if (index == 3)
            {
                PlayerFace.GetComponent<MeshRenderer>().material.color = Color.magenta;
                //Debug.Log("Ball color is : WHITE" + index);
            }

            Instantiate(BallArray[index],FirePoint.transform.position,transform.rotation);
            //GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>().AddForce(Vector3.forward * 100, ForceMode.Impulse);

        }
    }
}
