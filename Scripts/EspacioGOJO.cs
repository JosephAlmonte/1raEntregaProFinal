using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class EspacioGOJO : MonoBehaviour
{
	public VideoPlayer video;
	public Animator CanvaVideo,CanvaVideo1,CanvaVideo2,CanvaInfos;
	public Button BtnPlanetas,BtnTierra,BtnGalaxias,BtnNebulosas;
	
	public Button BtnVolverPlanetas;
	
	public GameObject CanvaPantalla,CanvaPlanetas,CanvaGalaxias,CanvaNebulosas,CanvasNebulosaMedusa,CanvasCrescent_Nebula,CanvasTheTadpoleNebula,
		CanvasJellyFishNebula,CanvasM8_M20,CanvasTrifid_Nebula,CanvasMonkeyHeadNebula,CanvasNorthAmericaPelicanNebula,CanvasPelicanNebula,CanvasRosetteNebula,
		CanvasWesterandEaster;
	
	
	public Button BtnMarte,BtnSaturno,BtnMercurio,BtnUrano,BtnPluton,BtnNeptuno,BtnVenus,BtnJupiter,BtnSol,BtnVolverGalaxia,BtnVolverNebulosas;
	
	public GameObject PlanetaMarte,PlanetaSaturno,PlanetaMercurio,PlanetaUrano,PlanetaPluton,PlanetaNeptuno
		,PlanetaVenus,PlanetaJupiter,PlanetaTierra,ElSol,CanvaAndromeda,CanvaTriangulo;
	
	
	DatosPlanetas Datos;
	
	public Button BtnAndromeda,BtnTriangulo,BtnLuna;

	
	public Button BtnMedusa,BtnCresentNebulla,BtnTadpoleNebula,BtnJellyFishNebula,BtnTrifid_Nebula;
	
	
	public GameObject CanvaMedusa,CanvaCresentNebulla,CanvaTadpoleNebula,CanvaJellyFishNebula,CanvaTrifid_Nebula;
	
    // Start is called before the first frame update
    void Start()
	{
		Datos=GameObject.FindGameObjectWithTag("Espacio").GetComponent<DatosPlanetas>();
		
		
		
		BtnPlanetas.onClick.AddListener(()=>Opcion(1));
		BtnVolverPlanetas.onClick.AddListener(()=>volver(1));
		BtnVolverGalaxia.onClick.AddListener(()=>volver(2));
		BtnVolverNebulosas.onClick.AddListener(()=>volver(3));
		BtnTierra.onClick.AddListener(()=>planetas(1));
		BtnMarte.onClick.AddListener(()=>planetas(2));
		BtnSaturno.onClick.AddListener(()=>planetas(3));
		BtnMercurio.onClick.AddListener(()=>planetas(4));
		BtnUrano.onClick.AddListener(()=>planetas(5));
		BtnPluton.onClick.AddListener(()=>planetas(6));
		BtnNeptuno.onClick.AddListener(()=>planetas(7));
		BtnVenus.onClick.AddListener(()=>planetas(8));
		BtnJupiter.onClick.AddListener(()=>planetas(9));
		BtnSol.onClick.AddListener(()=>planetas(10));
		
		BtnAndromeda.onClick.AddListener(()=>planetas(11));
		BtnTriangulo.onClick.AddListener(()=>planetas(12));
		
		BtnGalaxias.onClick.AddListener(()=>Opcion(2));
		BtnNebulosas.onClick.AddListener(()=>Opcion(3));
		
		BtnLuna.onClick.AddListener(()=>planetas(13));
		
		
		
		BtnMedusa.onClick.AddListener(()=>planetas(14));
		BtnCresentNebulla.onClick.AddListener(()=>planetas(15));
		BtnTadpoleNebula.onClick.AddListener(()=>planetas(16));
		BtnJellyFishNebula.onClick.AddListener(()=>planetas(17));
		BtnTrifid_Nebula.onClick.AddListener(()=>planetas(18));
		
		
    }



	public	void volver(int volver)
	{
		CanvaPantalla.SetActive(true);
		
		switch (volver)
		{
			
		case 1:
			CanvaPlanetas.SetActive(false);
			break;
			
		case 2:
			CanvaGalaxias.SetActive(false);
			break;	
			
			
		case 3:
			CanvaNebulosas.SetActive(false);
			break;		
			
		}
		
		
		
		
	}


	
	void Opcion(int opc)
	{
		CanvaPantalla.SetActive(false);
		
		switch (opc)
		{
		
		case 1:
			CanvaPlanetas.SetActive(true);
			break;
			
		case 2:
			CanvaGalaxias.SetActive(true);
			break;		
			
		case 3:
			CanvaNebulosas.SetActive(true);
			break;			
			
		}
	
		
		
		
	}// fin opcion



	public IEnumerator AnimateClose(int plane)
	{
		
		
		
		foreach (AnimationClip animationClip in CanvaVideo.runtimeAnimatorController.animationClips)
		{
			if (animationClip.name == "ApagaVideo")
			{
				//GetComponent<Animator>().Play(animationClip.name);
				yield return new WaitForSeconds(animationClip.length/2);
				CanvaVideo.SetBool("Viaje",false);
				CanvaVideo1.SetBool("Viaje",false);
				CanvaVideo2.SetBool("Viaje",false);
				CanvaInfos.SetBool("Inicio",false);
				ApagaPlanetas();
				
				Datos.InfoPlaneta(plane);
				
				ElSol.transform.localPosition=new Vector3(-4758f,99015f,-87896f);
				
				switch (plane)
				{
		
					
				case 1:
					float x=-13.42969f;
					float y=27.61951f;
					float z=294.3179f;
		
		
					PlanetaTierra.SetActive(true);
					PlanetaMarte.transform.localPosition=new Vector3(x,y,z);
					break;
			
				case 2:
		
					PlanetaMarte.SetActive(true);
					PlanetaMarte.transform.localPosition=new Vector3(967,-567,2399);
					break;
					
				case 3:
		
					PlanetaSaturno.SetActive(true);
					PlanetaSaturno.transform.localPosition=new Vector3(967,-3849,40412);
					break;
					
				case 4:
		
					PlanetaMercurio.SetActive(true);
					PlanetaMercurio.transform.localPosition=new Vector3(-1.2f,-4.6f,49.2f);
					break;
					
				case 5:
		
					PlanetaUrano.SetActive(true);
					PlanetaUrano.transform.localPosition=new Vector3(324,0,3804);
					break;
					
				case 6:
		
					PlanetaPluton.SetActive(true);
					PlanetaPluton.transform.localPosition=new Vector3(1.4f,0.4f,71);
					break;
					
				case 7:
		
					PlanetaNeptuno.SetActive(true);
					PlanetaNeptuno.transform.localPosition=new Vector3(0,0,3535);
					break;
					
					
				case 8:
		
					PlanetaVenus.SetActive(true);
					PlanetaVenus.transform.localPosition=new Vector3(0,2.2f,37);
					break;
					
					
				case 9:
		
					PlanetaJupiter.SetActive(true);
					PlanetaJupiter.transform.localPosition=new Vector3(-26,1095,12476.32f);
					break;
					
					
				case 10:
		
					
					ElSol.transform.localPosition=new Vector3(-2932f,0,36652f);
					break;	
			
			
				case 11:
		
					
					CanvaAndromeda.SetActive(true);
					break;	
			
			
				case 12:
		
					
					CanvaTriangulo.SetActive(true);
					break;	
			
			
				case 14:
		
					
					CanvaMedusa.SetActive(true);
					break;	
			
			
			
				case 15:
		
					
					CanvaCresentNebulla.SetActive(true);
					break;	
			
			
			
				case 16:
		
					
					CanvaTadpoleNebula.SetActive(true);
					break;	
			
			
				case 17:
		
					
					CanvaJellyFishNebula.SetActive(true);
					break;	
					
				case 18:
		
					
					CanvaTrifid_Nebula.SetActive(true);
					break;	
			
					
					
				}// fin swicht
		
				
				
				
			}
		}
		
		
		
		
		
		
	}



	void planetas(int plane)
	{
		
		CanvaVideo.SetBool("Viaje",true);
		CanvaVideo1.SetBool("Viaje",true);
		CanvaVideo2.SetBool("Viaje",true);
		CanvaInfos.SetBool("Inicio",true);
		video.Play();
		StartCoroutine(AnimateClose(plane));
		
	
		
	}


	void ApagaPlanetas()
	{
		ElSol.transform.localPosition=new Vector3(-134708f,99015f,10670f);
		PlanetaMarte.SetActive(false);
		PlanetaSaturno.SetActive(false);
		PlanetaMercurio.SetActive(false);
		PlanetaUrano.SetActive(false);
		PlanetaPluton.SetActive(false);
		PlanetaNeptuno.SetActive(false);
		PlanetaVenus.SetActive(false);
		PlanetaJupiter.SetActive(false);
		PlanetaTierra.SetActive(false);
		CanvaTriangulo.SetActive(false);
		CanvaAndromeda.SetActive(false);
		CanvaMedusa.SetActive(false);
		CanvaCresentNebulla.SetActive(false);
		CanvaTadpoleNebula.SetActive(false);
		CanvaJellyFishNebula.SetActive(false);
		CanvaTrifid_Nebula.SetActive(false);
		
		
		
	}



    // Update is called once per frame
    void Update()
	{
		//foreach (AnimationClip animationClip in CanvaVideo.runtimeAnimatorController.animationClips)
		//{
		//	if (animationClip.name == "AntesDelViaje")
		//	{
		//		if(animationClip.)
		//		//	CanvaVideo.SetBool("Viaje",false);
		//	}
		//}
    	
        
    }
}
