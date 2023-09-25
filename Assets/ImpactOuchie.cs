using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ImpactOuchie : MonoBehaviour {
		void OnCollisionEnter(Collision collision) {
				if (collision.transform.CompareTag("FirstPersonController")) {
						HealthSystemForDummies healthSystem = collision.gameObject.GetComponent<HealthSystemForDummies>();
		
					 
						healthSystem.AddToCurrentHealth(-25);			
				}
		}
}
