using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TemporizadordelVideos : MonoBehaviour
{
	// OnTriggerEnter is called when the Collider other enters the trigger.
	protected void OnTriggerEnter(Collider other)
	{
		//other.transform.position = new	 Vector3(507.92f,55.88f,510.32f);
		
		if (other.name == "XR Origin (1)")
		{
			SceneManager.LoadScene("EspacioGOD");
		}
	}
}
