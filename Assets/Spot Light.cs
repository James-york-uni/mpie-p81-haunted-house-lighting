using UnityEngine;

public class Torch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject player;
    bool torch = true;

    // Update is called once per frame
    void Update()
    {
        Transform t = gameObject.transform;

        if(torch == true) {
            if(Input.GetKeyDown(KeyCode.F)) {
                t.Translate(100f, 0f, 0f);
                torch = false;
            }
                
        }

        else if(torch == false) {
            if(Input.GetKeyDown(KeyCode.F)) {
                t.transform.position = player.transform.position; 
                torch = true;
            }
                
        }
    }
}
