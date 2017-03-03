using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
		{
		   transform.position += Vector3.forward * speed  * 0.1f;
		}

		if(Input.GetKey(KeyCode.S))
		{
		   transform.position -= Vector3.forward * speed * 0.1f;
		}
		if(Input.GetKey(KeyCode.A))
		{
		   transform.position -= Vector3.right * speed * 0.1f;
		}
		if(Input.GetKey(KeyCode.D))
		{
		   transform.position += Vector3.right * speed * 0.1f;
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * (speed / 10);
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.position -= Vector3.up * (speed / 10);
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(Vector3.up * speed * 45 * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(Vector3.up * speed * -45 * Time.deltaTime);
		}
	}
}
