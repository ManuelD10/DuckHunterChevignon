﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace ShootingGallery.Types
{
	/// <summary>
	/// This script changes the text based on the platform type we are using.
	/// </summary>
	public class SGTTextByPlatform:MonoBehaviour
	{
		// The text that will be displayed on PC/Mac/Webplayer
		public string computerText = "CLICK PARA EMPEZAR";
	
		// The text that will be displayed on Android/iOS/WinPhone
		public string mobileText = "TAP PARA INICIAR";
	
		// The text that will be displayed on Playstation, Xbox, Wii
		public string consoleText = "PRESS 'A' TO START";

		// The UI graphic that will be displayed on PC/Mac/Webplayer
	
		/// <summary>
		/// Start is only called once in the lifetime of the behaviour.
		/// The difference between Awake and Start is that Start is only called if the script instance is enabled.
		/// This allows you to delay any initialization code, until it is really needed.
		/// Awake is always called before any Start functions.
		/// This allows you to order initialization of scripts
		/// </summary>
		void Start()
		{
			if ( Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.WindowsWebPlayer || Application.platform == RuntimePlatform.OSXWebPlayer || Application.platform == RuntimePlatform.OSXDashboardPlayer || Application.platform == RuntimePlatform.LinuxPlayer )
			{
				GetComponent<Text>().text = computerText;
			}
			else if ( Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.WP8Player )
			{
				GetComponent<Text>().text = mobileText;
			}
			else if ( Application.platform == RuntimePlatform.PS3 || Application.platform == RuntimePlatform.XBOX360 || Application.platform == RuntimePlatform.PS4 || Application.platform == RuntimePlatform.XboxOne )
			{
				GetComponent<Text>().text = consoleText;
			}
		}
	}
}