using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Tutorialvideo : MonoBehaviour
{
	public	Button vid,atras;
	public GameObject viP,BTatras;
	public VideoPlayer Video;
	
	
	void Start(){
		
		vid.onClick.AddListener(prender);
		atras.onClick.AddListener(Cerrar);
	}
	
	
	void prender(){
		
		viP.SetActive(true);
		BTatras.SetActive(true);
		Video = GetComponent<VideoPlayer>();
		
	}
	
	void Cerrar(){
		viP.SetActive(false);
		BTatras.SetActive(false);
		
	}
   
}
