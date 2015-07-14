using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour 
{
	public Light Light;
	public Light Light2;
	public Light Light3;
	public Light Light4;
	public Light Light5;
	public Light Light6;
	public Light Light7;
	public Light Light8;
	public Light Light9;
	public Light Light10;
	public Light Light11;
	public Light Light12;
	public Light Light13;
	public Light Light14;
	public Light Light15;

	public GameObject goLightSwitch;
	public AudioClip SwitchOn;
	public AudioClip SwitchOff;
	
	private bool _switchOn;
	private GameObject _upPosition;
	private GameObject _downPosition;
	
	private AudioSource _audioSource;

	void Awake()
	{
		_upPosition = GameObject.Find ("UpPosition");
		_downPosition = GameObject.Find("DownPosition");
		_audioSource = gameObject.GetComponentInChildren<AudioSource>();



		
	}
	void OnMouseDown()
	{
		if (_switchOn) 
		{
			_switchOn = false;
			goLightSwitch.transform.position = new Vector3(goLightSwitch.transform.position.x,_downPosition.transform.position.y,goLightSwitch.transform.position.z);
			
			Light.enabled = false;
			Light2.enabled = false;
			Light3.enabled = false;
			Light4.enabled = false;
			Light5.enabled = false;
			Light6.enabled = false;
			Light7.enabled = false;
			Light8.enabled = false;
			Light9.enabled = false;
			Light10.enabled = false;
			Light11.enabled = false;
			Light12.enabled = false;
			Light13.enabled = false;
			Light14.enabled = false;
			Light15.enabled = false;

			_audioSource.clip = SwitchOff;
			_audioSource.Play ();
			
		}
		
		else if (!_switchOn) 
		{
			_switchOn = true;
			goLightSwitch.transform.position = new Vector3(goLightSwitch.transform.position.x,_upPosition.transform.position.y,goLightSwitch.transform.position.z);
			
			Light.enabled = true;
			Light2.enabled = true;
			Light3.enabled = true;
			Light4.enabled = true;
			Light5.enabled = true;
			Light6.enabled = true;
			Light7.enabled = true;
			Light8.enabled = true;
			Light9.enabled = true;
			Light10.enabled = true;
			Light11.enabled = true;
			Light12.enabled = true;
			Light13.enabled = true;
			Light14.enabled = true;
			Light15.enabled = true;

			_audioSource.clip = SwitchOn;
			_audioSource.Play ();
			
			
		}
		
		
	}
}
