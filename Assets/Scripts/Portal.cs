using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** portal that display what it sees on the other portal and manage teleportation **/
public class Portal : MonoBehaviour
{

    // the other portal
    [SerializeField]
    private Portal linkedPortal;

    [SerializeField]
    private MeshRenderer screen;

    [SerializeField]
    private Camera cam;

    // texture for the other portal
    private RenderTexture viewTexture;

    // Start is called before the first frame update
    void Start()
    {
        viewTexture = new RenderTexture(Screen.width, Screen.height, 0);
        cam.targetTexture = viewTexture;
        linkedPortal.screen.material.SetTexture("_MainTex", viewTexture);

        //cam.enabled = false;
    }

    private void Update()
    {
        cam.transform.localPosition = Camera.main.transform.position- linkedPortal.transform.position;
        cam.transform.rotation = Camera.main.transform.rotation;
    }


}
