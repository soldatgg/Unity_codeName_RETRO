using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTNclipManag : MonoBehaviour
{

    public MeshRenderer TestMesh;
    public GameObject ClipManager;
    public bool TestClip;
    public bool MoveClip;
    public bool AnchorMoveClip;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


    }

    private void Unable()
    {
        TestMesh.enabled = true;

    }

    private void Disable()
    {
        TestMesh.enabled = false;

    }

}
