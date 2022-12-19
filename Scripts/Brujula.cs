using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brujula : MonoBehaviour
{
	public Transform PlayerTransform;
	Vector3 dir;
	
	
	
    // Update is called once per frame
    void Update()
	{
		if (SceneManager.GetActiveScene().name=="Dunas de Bani"||SceneManager.GetActiveScene().name=="Samana")
		{
			dir.z= PlayerTransform.eulerAngles.y+90f;
			transform.localEulerAngles= dir;
		}
		if (SceneManager.GetActiveScene().name=="Valle nuevo"||SceneManager.GetActiveScene().name=="Bayahibe")
		{
	    dir.z= PlayerTransform.eulerAngles.y;
			transform.localEulerAngles= dir;
		}
		
		//if (SceneManager.GetActiveScene().name=="Bayahibe")
		//{
		//	dir.z= PlayerTransform.eulerAngles.y;
		//	transform.localEulerAngles= dir;
		//}
		
		//if (SceneManager.GetActiveScene().name=="Samana")
		//{
		//	dir.z= PlayerTransform.eulerAngles.y+90f;
		//	transform.localEulerAngles= dir;
		//}
		
		
    }
}
