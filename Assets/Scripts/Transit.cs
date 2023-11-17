using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transit : MonoBehaviour
{
    public float gazeTime = 4f; // Время взгляда в секундах
    private float timer;
    private bool gazedAt;
    private RaycastHit hit;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.transform.CompareTag("Interactable"))
            {
                gazedAt = true;
            }
        }
        else
        {
            gazedAt = false;
            timer = 0f;
        }

        if (gazedAt)
        {
            timer += Time.deltaTime;

            if (timer >= gazeTime)
            {
                // Вызовите здесь функцию, которую вы хотите выполнить после фиксации взгляда.
                Debug.Log("Gaze activated on " + hit.transform.name);
                timer = 0f;
            }
        }
    }
}
