using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LanzamientoNave : MonoBehaviour
{
	public VideoPlayer Video;
	public Animator lazamineto;
	public GameObject CanVideo,but,c,XR,XR2;
	public Button  lANZAR,DEspe;
	
	void Start(){
		//lANZAR.onClick.AddListener(Lanz);
		//DEspe.onClick.AddListener(Inicio);
	}
	
	public void Lanz(){
		
		CanVideo.SetActive(true);
		c.SetActive(true);
		//but.SetActive(true);
		//Video = GetComponent<VideoPlayer>();
		Video.Play();
		XR.SetActive(false);
		XR2.SetActive(true);
		//Video.loopPointReached += Inicio(Video);
		StartCoroutine(Inicio());
	}
	
	
	IEnumerator  Inicio(){
		yield return new WaitForSeconds(11f);
		CanVideo.SetActive(false);
		//gameObject.SetActive(false);
		//but.SetActive(false);
		c.SetActive(false);
		lazamineto.SetBool("Inicio",true);
		StartCoroutine(inicio2());
		
	}
	
	
	IEnumerator  inicio2 ()
	{
		yield return new WaitForSeconds(10);
		Debug.Log("fjfjfjfjfjfjfj");
		SceneManager.LoadScene("Transbordador");
		
	}
	
	
}
