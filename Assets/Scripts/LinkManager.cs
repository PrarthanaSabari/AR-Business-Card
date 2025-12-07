using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkManager : MonoBehaviour
{
	public void openLinkedIn()
	{
		Application.OpenURL("http://www.linkedin.com/in/prarthana-s-73608a2ab");
	}

	public void openInstagram()
	{
		Application.OpenURL("https://www.instagram.com/prithika_boopathi_?igsh=M214bmxiZjZpcGI4&utm_source=qr");
	}

	public void openGithub()
	{
		Application.OpenURL("https://github.com/PrarthanaSabari");
	}

	public void openDiscord()
	{
		Application.OpenURL("https://discord.gg/R8Y7SP43");
	}

	public void openGmail()
	{
		Application.OpenURL("mailto:prarthana.s2022@vitstudent.ac.in");
	}
}
