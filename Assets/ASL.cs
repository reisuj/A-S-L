using UnityEngine;

public class ASL : MonoBehaviour
{
    [SerializeField] int _age;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You're age is " + _age + ".");
        }
    }
}
