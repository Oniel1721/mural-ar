using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonURL : MonoBehaviour
{
	
	/*public void openWeb(string url){
		Application.OpenURL(url);
	
	}*/
	
	public string IG = "https://instagram.com/t_ecogroup?utm_medium=copy_link";
	public string Tconet = "https://t-ecogroup.net/";
	
	public void URLIG(){
		
		Application.OpenURL(IG);
	}
	
	public void ULRTco(){
		
		Application.OpenURL(Tconet);
	}
	
	void LaAurora()
	{
		Application.OpenURL("https://www.laaurora.com.do/?lang=en");
	}
	
}
