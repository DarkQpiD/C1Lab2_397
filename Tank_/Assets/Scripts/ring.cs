using UnityEngine;

public class ring : MonoBehaviour
{
    public int numberOfObjects = 20; // Number of objects to instantiate
    public float radius = 5f; // Radius of the circle
    public GameObject prefab; // Prefab of the object to instantiate

    void Start()
    {
        MakeCircle();
    }

    void MakeCircle()
    {
        float angleIncrement = 360f / numberOfObjects;

        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = angleIncrement * i;
            float x = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
            float z = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;
            Vector3 position = new Vector3(x, 3, z); // Adjusted y position if needed

            // Instantiate the prefab at 'position' with no rotation
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}
