using UnityEngine;

public class Torch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = gameObject.transform;
        bool torch = true;
        x = 

        if(Input.GetKey (KeyCode.F)) {
            if(torch) {
                torch = false;
                t.Translate(100f, 0f, 0f);
            }

            if(torch == false) {
                torch = true;
                t.Translate();
            }
        }
    }
}
