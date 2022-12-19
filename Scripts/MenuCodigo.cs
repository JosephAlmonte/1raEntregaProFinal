using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuCodigo : MonoBehaviour
{
	
	public GameObject CanvaMenu;
	
		public Animator Animacion;
	
	
	public Button BtnConfig,BtnAstroTurismo,BtnTurismoEspacial,BtnAtrasMenu;
	
	//AstroTurismoVentana
	public Button BtnDominicus,BtnSamana,BtnValleNuevo,BtnDunas,BtnAtrasAstroT,cerrarapp;
	
	
	//TurismoEspacial
	public Button BtnArea,BtnExploracion,BtnVista,BtnAtrasTurismoE,BtnSalir;
	
	
	
	//Configuracion
	public Button btnControlVol,BtnContolMov;
	
	public GameObject VentanaVol,VentanaMov;
	
	
    // Start is called before the first frame update
    void Start()
	{
		
		BtnDominicus.onClick.AddListener(()=> Lugares(4));
		BtnSamana.onClick.AddListener(()=> Lugares(3));
		BtnValleNuevo.onClick.AddListener(()=> Lugares(2));
		BtnDunas.onClick.AddListener(()=> Lugares(1));
		BtnVista.onClick.AddListener(()=> Lugares(5));
		BtnArea.onClick.AddListener(()=> Lugares(6));
		BtnExploracion.onClick.AddListener(()=> Lugares(5));
	
		
		if (SceneManager.GetActiveScene().name =="Bienvenido")
		{
			BtnConfig.onClick.AddListener(()=> Opcion(4));
		}
		else
		{
			BtnConfig.onClick.AddListener(()=> Opcion(1));
			
		}
			BtnAstroTurismo.onClick.AddListener(()=> Opcion(2));
			BtnTurismoEspacial.onClick.AddListener(()=> Opcion(3));
		BtnAtrasTurismoE.onClick.AddListener(()=> Opcion(0));
		BtnAtrasMenu.onClick.AddListener(()=> Opcion(0));
		BtnAtrasAstroT.onClick.AddListener(()=> Opcion(0));
		
		btnControlVol.onClick.AddListener(()=> VentanasConfig(1));
		BtnContolMov.onClick.AddListener(()=> VentanasConfig(2));
		BtnSalir.onClick.AddListener(()=> Apagar());
		
	
	}
    
	
	
	void Apagar()
	{
		
		Application.Quit();
		
	}
	
	


	void VentanasConfig(int ven)
	{
		switch (ven)
		{
		
		case 1:
			VentanaVol.SetActive(true);
			VentanaMov.SetActive(false);
			break;
			
			
		case 2:
			VentanaVol.SetActive(false);
			VentanaMov.SetActive(true);
			break;	
		}
		
	}
	
	
	

	void Opcion (int numero)
	{
		
		Animacion.SetInteger("Opcion",numero);
		
	}


	public void Activar()
	{
		
		CanvaMenu.SetActive(true);
		Animacion.SetBool("Encendido",true);
		
		
	}


	public void cerrar()
	{
		CanvaMenu.SetActive(false);
		Animacion.SetBool("Encendido",false);
		
	}

     

    // Update is called once per frame
    void Update()
	{
		
        
	}
    
    
    
    
	void Lugares(int lugar)
	{
		
		switch (lugar)
		{
		
		case 1:
			SceneManager.LoadScene("Dunas de Bani");
			break;
			
		case 2:
			SceneManager.LoadScene("Valle nuevo");
			break;
			
		case 3:
			SceneManager.LoadScene("Samana");
			break;
			
		case 4:
			SceneManager.LoadScene("Bayahibe");
			break;	
			
		case 5:
			SceneManager.LoadScene("EspacioGOD");
			break;	
			
		case 6:
			SceneManager.LoadScene("Plataforma de Lazamiento");
			break;
		}
		
	}// fin lugares
    
    
    
    
    
}
