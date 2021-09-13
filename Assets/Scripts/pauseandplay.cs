using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class pauseandplay : MonoBehaviour
{
	public VideoPlayer video;
	
	public void play(){
		
		video.Play();
	}
	
	public void Pause(){
		
		video.Pause();
	}
   
}
