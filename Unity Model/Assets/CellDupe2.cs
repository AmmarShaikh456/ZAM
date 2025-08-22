using UnityEngine;

public class CellDupe1 : MonoBehaviour
{
    public GameObject test;

    void Start()
    {
        // ...existing code...
    }

    void Update()
    {
        // Stretch in X when W is pressed
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 scale = test.transform.localScale;
            scale.x *= 2; // Stretch X
            scale.y *= 0.5f; // Make skinnier in Y
            test.transform.localScale = scale;
        }

        // Stretch in Y when S is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 scale = test.transform.localScale;
            scale.y *= 2; // Stretch Y
            scale.x *= 0.5f; // Make skinnier in X
            test.transform.localScale = scale;
        }
    }
}