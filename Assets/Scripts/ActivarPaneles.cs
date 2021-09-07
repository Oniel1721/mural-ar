using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPaneles : MonoBehaviour
{
	//Paneles
	public GameObject PanelInicio;
	public GameObject PanelMenu;
	public GameObject PanelEscanea;
	public GameObject PanelGuillermo;
	public GameObject PanelAurora;
	public GameObject PanelConocenos;
	public GameObject PanelTutorial;
	public GameObject PanelFoto;
	public GameObject PanelSobreMural;
	public GameObject PanelRespuestas;

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		EncenderUnPanel(PanelInicio);
	}
	
	//Funcion que enciende un panel
	public void EncenderUnPanel (GameObject PanelAEncender){
		
		//Apago los paneles
		PanelInicio.SetActive(false);
		PanelMenu.SetActive(false);
		PanelEscanea.SetActive(false);
		PanelGuillermo.SetActive(false);
		PanelAurora.SetActive(false);
		PanelConocenos.SetActive(false);
		PanelTutorial.SetActive(false);
		PanelFoto.SetActive(false);
		PanelSobreMural.SetActive(false);
		PanelRespuestas.SetActive(false);
		
		//Activo el argumento
		PanelAEncender.SetActive(true);
	}
   
}
