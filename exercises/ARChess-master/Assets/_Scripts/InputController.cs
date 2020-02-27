using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    Transform selectedPiece;
    Transform selectedSquare;

    // Start is called before the first frame update
    void Start()
    {

    }

    void selectPiece(Transform piece)
    {
        deselectPiece(); //when selecting a new piece, STOP highlighting/selecting the previous one

        selectedPiece = piece;

        Renderer[] renderers = selectedPiece.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in renderers)
        {
            r.material.EnableKeyword("_EMISSION");
            r.material.SetColor("_EmissionColor", Color.red);
        }
    }

    void deselectPiece()
    {
        if (selectedPiece)
        {
            Renderer[] renderers = selectedPiece.GetComponentsInChildren<Renderer>(); //"collection" (basically an array) of renderers of ALL of the children in this piece of the type renderer
            foreach (Renderer r in renderers) //in every single execution of this loop, give me each renderer. then disable the emission, and change it to black.
            {
                r.material.DisableKeyword("_EMISSION"); //EMISSION is an aspect of materials, changes that property of material shader
                r.material.SetColor("_EmissionColor", Color.black);
            }
        }

        selectedPiece = null;
    }

    void selectSquare(Transform square)
    {
        deselectSquare();

        selectedSquare = square; //keeping the reference here so we can use it outside any time we want
        selectedSquare.GetComponent<MeshRenderer>().material.color = new Color(1, 0, 0, 0.3f);
    }

    void deselectSquare()
    {
        if (selectedSquare)
        {
            selectedSquare.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0, 0.0f);
        }
        selectedSquare = null;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //origin of ray- camera, going to mouse position

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100)) //checking whether the cursor line-- going up to 100m-- will hit any collider. "out" puts a value inside the variable "hit"... if you use OUT, when you are OUT of this function, you have the value within it still
        {
            if (hit.transform.tag == "square" && selectedPiece)
            {
                selectSquare(hit.transform); //pass the hit.transform as a parameter of the function

                if (Input.GetMouseButtonDown(0))
                {
                    selectedPiece.position = hit.transform.position;
                    deselectPiece();
                }
            }

            if (Input.GetMouseButtonDown(0) && hit.transform.tag == "piece")
            {
                selectPiece(hit.transform);
            }
        }
    }
}