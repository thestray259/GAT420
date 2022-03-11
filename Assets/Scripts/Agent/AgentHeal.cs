using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentHeal : MonoBehaviour
{
	[SerializeField] string tagName;
	[SerializeField] float distance;
	[SerializeField] float healValue;

	public void Heal()
	{
		Collider[] colliders = Physics.OverlapSphere(transform.position, distance);
		foreach (Collider collider in colliders)
		{
			if (collider.gameObject == gameObject) continue;

			if (tagName == "" || collider.CompareTag(tagName))
			{
				if (collider.gameObject.TryGetComponent<StateAgent>(out StateAgent stateAgent))
				{
					stateAgent.health.value += healValue;
				}
			}
		}
		//StateAgent stateAgent = new StateAgent(); 
		//stateAgent.health.value += healValue;
	}
}
