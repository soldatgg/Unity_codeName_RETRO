using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CTNmainIntroSccript : MonoBehaviour
{

    public float waitTime = 5f;
    public bool status = false;
    public bool OOF_status = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting The Game !!");
        Debug.Log("CTN-Engine is not start");

        if (!OOF_status)
            Debug.LogError("OOF that hurts");
        if (!status)
            Debug.LogError("CTN-engine can't start. That can create various bugs ang crash");

        //starting the intro / demo on the start of the game

        // wait a cetrain time you can ajust on the inspector for charging the level after the intro
        StartCoroutine(WaitForIntro());
        

    }

    private IEnumerator WaitForIntro()
    {
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Changing the scene");
        SceneManager.LoadScene(1);
        Debug.Log("First level charged");

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
