using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the other object has a tag of "Player"
        if (other.gameObject.CompareTag("Player"))
        {
            // Calculate the scale of this object and the other object
            float scaleThis = CalculateScale(this.transform.localScale);
            float scaleOther = CalculateScale(other.transform.localScale);

            // If the other object's scale is at least twice as large, destroy this object
            if (scaleOther >= scaleThis * 2)
            {
                Destroy(gameObject);

                // Check if this object has a parent and destroy the parent as well
                if (gameObject.transform.parent != null)
                {
                    Destroy(gameObject.transform.parent.gameObject);
                }

                // Reset the player's scale to 1,1,1
                other.transform.localScale = new Vector3(1f, 1f, 1f);
            }
        }
    }

    private float CalculateScale(Vector3 scale)
    {
        return scale.x * scale.y * scale.z;
    }
}
