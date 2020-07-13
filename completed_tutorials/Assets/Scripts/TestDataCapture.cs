using Unity.Simulation;
using UnityEngine;

public class TestDataCapture : MonoBehaviour
{
    private Unity.Simulation.Logger dataLogger;

    // Create and Log a vector
    void Start()
    {
        // Print the location where data will be written
        Debug.Log(Application.persistentDataPath + "/" + Configuration.Instance.GetAttemptId());

        // Create new data logger with output files named DataCapture
        dataLogger = new Unity.Simulation.Logger("DataCapture");

        Vector3 examplePosition = new Vector3(0, 1, 2);

        //Create a new data point
        ObjectPosition objectPosition = new ObjectPosition(examplePosition, "ExampleObjectName");
        dataLogger.Log(objectPosition);

        // Flush written objectPosition to file
        dataLogger.Flushall();
    }
}