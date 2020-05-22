using UnityEngine;
using System.Collections;

public class URL_texture : MonoBehaviour {
	public string url = "http://instcomputer.ru/wp-content/uploads/2019/01/oshibka-err-internet-disconnected.jpg";

	IEnumerator Start()
	{
		if (Application.internetReachability != NetworkReachability.NotReachable)
		{  
		if (null == url || url.Length < 1) {
			Debug.Log ("No url");
			yield return null;
		} else {
			Texture2D tex;
			tex = new Texture2D (4, 4, TextureFormat.DXT1, false);
			WWW www = new WWW (url);
			yield return www;
			www.LoadImageIntoTexture (tex);
			GetComponent<Renderer> ().material.mainTexture = tex;
		}
	}
        

	}
}