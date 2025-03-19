using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject cubeee;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(message:"OnTriggerEnter");
        //GameObject cubeee = GameObject.Find("Cubeee");
        cubeee.SetActive(true);
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(message:"OnCollisionEnter");
        //other.gameObject.SetActive(false);
    }
}
