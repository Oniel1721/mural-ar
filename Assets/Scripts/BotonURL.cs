using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonURL : MonoBehaviour
{
	
	/*public void openWeb(string url){
		Application.OpenURL(url);
	
	}*/
	
	void Start()
	{
		Application.OpenURL("https://www.laaurora.com.do/?lang=en");
	}
}
