using UnityEngine;

public class LightOffTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ManualCar"))
        {
            // Try to find the Light component attached to the car or its children
            Light spotlight = other.GetComponentInChildren<Light>();
            if (spotlight != null)
            {
                spotlight.enabled = false; // Turn off the spotlight
            }
            else
            {
                Debug.LogWarning("No Light component found on the car.");
            }
        }
    }
}