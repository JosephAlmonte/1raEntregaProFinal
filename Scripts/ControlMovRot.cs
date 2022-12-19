using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ControlMovRot : MonoBehaviour
{
	

	public  Slider SliderMov,SliderRot;
	
	public Button BtnMasMov,BtnMenosMov,BtnMasRot,BtnMenosRot;
	
	public GameObject locomocion;
	
	private float MovDef,RotDef;
	
	
	
	// Start is called before the first frame update
	void Start()
	{
			
		float MovGuardado = PlayerPrefs.GetFloat("GuardaMov");
		locomocion.GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed=MovGuardado;
		if (MovGuardado==0)
		{
			locomocion.GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed=15;
		}
		SliderMov.value=MovGuardado;
		BtnMasMov.onClick.AddListener(()=> CambiaMov(1));
		BtnMenosMov.onClick.AddListener(()=> CambiaMov(2));
		
		
		// Rotacion
		float RotGuardado = PlayerPrefs.GetFloat("GuardaRot");
		locomocion.GetComponent<ActionBasedContinuousTurnProvider>().turnSpeed=RotGuardado;
		if (RotGuardado==0)
		{
			locomocion.GetComponent<ActionBasedContinuousTurnProvider>().turnSpeed=60;
		}
		SliderRot.value=RotGuardado;
		BtnMasRot.onClick.AddListener(()=> CambiaRot(1));
		BtnMenosRot.onClick.AddListener(()=> CambiaRot(2));
		
	}
    
    
	public void CambiaMov(int num)
	{
		float velocidad =locomocion.GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed;
		switch (num)
		{
		
		case 1:
			if (velocidad<25)
			{
				velocidad=velocidad+5;
				MovDef=locomocion.GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed=velocidad;
				SliderMov.value=MovDef;
				GuardaMov();
			}
			break;
			
		case 2:
			if (velocidad>10)
			{
				velocidad=velocidad-5;
				MovDef=locomocion.GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed=velocidad;
				SliderMov.value=MovDef;
				GuardaMov();
			}
			break;	
			
		}
		
		
		
	}
	
	
	
	public void CambiaRot(int num)
	{
		float rotacion =locomocion.GetComponent<ActionBasedContinuousTurnProvider>().turnSpeed;
		switch (num)
		{
		
		case 1:
			if (rotacion<75)
			{
				rotacion=rotacion+5;
				RotDef=locomocion.GetComponent<ActionBasedContinuousTurnProvider>().turnSpeed=rotacion;
				SliderRot.value=RotDef;
				GuardaRot();
			}
			break;
			
		case 2:
			if (rotacion>50)
			{
				rotacion=rotacion-5;
				RotDef=locomocion.GetComponent<ActionBasedContinuousTurnProvider>().turnSpeed=rotacion;
				SliderRot.value=RotDef;
				GuardaRot();
			}
			break;	
			
		}
		
		
		
	}
	
	
	
	
	public void GuardaMov()
	{
		
		PlayerPrefs.SetFloat("GuardaMov", MovDef);
	}
	
	public void GuardaRot()
	{
		
		PlayerPrefs.SetFloat("GuardaRot", RotDef);
	}
	
	

	// Update is called once per frame
	void Update()
	{
        
	}
}
