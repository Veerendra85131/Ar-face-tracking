using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARFaceManager))]
public class FaceController : MonoBehaviour
{
  

    private ARFaceManager arFaceManager;



    private int swapCounter = 0;

    [SerializeField]
    public FaceMaterial[] materials;

    void Awake()
    {
        arFaceManager = GetComponent<ARFaceManager>();

      

        arFaceManager.facePrefab.GetComponent<MeshRenderer>().material = materials[0].Material;
    }

    public void Faceone()
    {
       

        foreach (ARFace face in arFaceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = materials[0].Material;
        }

     
    }
    public void Facetwo()
    {
       

        foreach (ARFace face in arFaceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = materials[1].Material;
        }

      
    }
    public void Facethree()
    {
        
        foreach (ARFace face in arFaceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = materials[2].Material;
        }

       
    }
  

}

[System.Serializable]
public class FaceMaterial
{
    public Material Material;

   
}
