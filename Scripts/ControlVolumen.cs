using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlVolumen : MonoBehaviour
{
	
	public AudioSource Sonido;
	public  Slider SliderSonido;
	
	public Button BtnMas,BtnMenos;
	
	
	
	
	
	
    // Start is called before the first frame update
    void Start()
	{
		float VolGuardado = PlayerPrefs.GetFloat("GuardaVol");
		
		if (VolGuardado==0)
		{
			VolGuardado=0.1f;
			SliderSonido.value=VolGuardado;
		}
		else{
			SliderSonido.value=VolGuardado;
			Sonido.volume=VolGuardado;
			}
		BtnMas.onClick.AddListener(()=> CambiaVol(1));
		BtnMenos.onClick.AddListener(()=> CambiaVol(2));
		
    }
    
    
	public void CambiaVol(int num)
	{
		switch (num)
		{
		
		case 1:
			Sonido.volume= Sonido.volume+0.1f;
			SliderSonido.value=Sonido.volume;
			Debug.Log("CambiaVol+");
			GuardaVol();
			break;
			
		case 2:
			Sonido.volume= Sonido.volume-0.1f;
			SliderSonido.value=Sonido.volume;
			Debug.Log("CambiaVol-");
			GuardaVol();
			break;	
			
		}
		
		
		
	}
	
	
	
	public void GuardaVol()
	{
		PlayerPrefs.SetFloat("GuardaVol", Sonido.volume);
	}
	
	
	
	

    // Update is called once per frame
    void Update()
    {
        
    }
}
