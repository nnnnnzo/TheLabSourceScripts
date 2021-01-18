using UnityEngine;
using System.Collections;

public class LerpPortal : MonoBehaviour 
{
    //Object that you want to move/lerp from start to end
	public GameObject wall;

    //Start position of the object
	private Vector3 startPos;
    //End position of the object
	private Vector3 endPos;

    //Distance from start to end
	public float distance = 30f;

    //Time taken to move the object from the start to end
	public float lerpTime = 3f;

    //Time will be added till it meets lerpTime and do certain conditions
	private float currentLerpTime = 0;

    //Prevent user to spam the movement of the object and causes bug
	private bool keyHit = false;
	public bool SlideOn = false;

	private float keypressed = 0;
	public AudioSource audioSource;
    public float volume=1f;



    void Update () 
    {
        //Object movement procedure
		if (SlideOn == true && keypressed == 0) 
        {
			audioSource.PlayOneShot(audioSource.clip, volume);
			//audioSource2.PlayOneShot(audioSource.clip, volumeJ);
            //Start position will be updated
			startPos = wall.transform.position;
            //End position will be updated
			endPos = wall.transform.position + Vector3.forward * distance;
			keyHit = true;
			keypressed = 1;
		}

		if (keyHit == true) 
        {
			currentLerpTime += Time.deltaTime;
			if(currentLerpTime >= lerpTime)
            {
				currentLerpTime = lerpTime;
				keyHit = false;
			}

			float Perc = currentLerpTime/lerpTime;
            //Object will move from start to end
			wall.transform.position = Vector3.Lerp (startPos, endPos, Perc);
		}

        if (keyHit == false)
        {
            //Set currentLerpTime to 0 so that the process can be restarted again
            currentLerpTime = 0;
        }
	}
}
