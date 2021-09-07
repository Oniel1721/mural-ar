using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
	
	
	public GameObject[] botones;
    // Start is called before the first frame update
	void Awake()
    {
	    DontDestroyOnLoad(this);
    }
    
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		SetActiveBotones(true);
	}
    
	void SetActiveBotones(bool valor){
		for(int i = 0; i < botones.Length; i++){
			botones[i].SetActive(valor);
		}
	}

    // Update is called once per frame
	public void TakeScreenShot(){
		string screenshotIMGName = System.DateTime.Now.ToString();
		string subString = screenshotIMGName.Replace('/', '_');
		string gypsy = subString.Replace(':', '_');
		SetActiveBotones(false);
		ScreenCapture.CaptureScreenshot(gypsy + ".png");
	}
}
