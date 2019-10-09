
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameObject completelevalUI;
    void OnTriggerEnter()
    {
        CompleteLeval(); 
    }
    public void CompleteLeval()
    {
        completelevalUI.SetActive(true);
    }
}
