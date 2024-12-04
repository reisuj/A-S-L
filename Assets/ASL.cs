using UnityEngine;

public class ASL : MonoBehaviour
{
    [SerializeField] int _age;
    [SerializeField] string _sex;
    [SerializeField] string _location;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("You're age is " + _age + ".");
            //Debug.Log("Your sex is " + _sex + ".");
            //Debug .Log("Your location is " + _location + ".");

            Debug.Log($"My age is {_age}, my sex is {_sex}, and my location is {_location}");
        }
    }
}
