using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() => NewMethod();

    private static object NewMethod()
    {
        return Debug.log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
