using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class HealthMonitor : MonoBehaviour
{

    public static int HealthValue;
    public int InternalHealth;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    public GameObject HealthText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    InternalHealth = HealthValue;
	    HealthText.GetComponent<Text>().text = InternalHealth.ToString();

        switch (HealthValue)

	    {
	        case 0:
	        {
	            Heart1.SetActive(false);
	            Heart2.SetActive(false);
	            Heart3.SetActive(false);
	            break;
	        }
	        case 1:
	        {
	            Heart1.SetActive(true);
	            break;
	        }
	        case 2:
	        {
	            Heart2.SetActive(true);
	            break;
	        }
	        case 3:
	        {
	            Heart3.SetActive(true);
	            break;
	        }            
	    }
	}
}
