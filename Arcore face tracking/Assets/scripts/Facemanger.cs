using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;

namespace UnityEngine.XR.ARFoundation
{
    public class Facemanger : MonoBehaviour
    {
        [SerializeField]

        public Material[] materials;

       // public Facematerial[] materials;

        private ARFaceManager aRFaceManager;
        bool faceone, facetwo, facethree;
        void Awake()
        {
            aRFaceManager = GetComponent<ARFaceManager>();
            aRFaceManager.facePrefab.GetComponent<MeshRenderer>().material = materials[1];
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if(faceone == true)
            {
                
                aRFaceManager.facePrefab.GetComponent<MeshRenderer>().material = materials[0];
                faceone = false;
            }

            if (facetwo == true)
            {
                aRFaceManager.facePrefab.GetComponent<MeshRenderer>().material = materials[1];
                facetwo = false;
            }
            if (facethree == true)
            {
                aRFaceManager.facePrefab.GetComponent<MeshRenderer>().material = materials[2];
                facethree = false;
            }
        }



        public void face1()
        {
            faceone = true;
          //  aRFaceManager = GetComponent<ARFaceManager>();
          //  aRFaceManager.facePrefab.GetComponent<MeshRenderer>().material = materials[0];

            //  Debug.Log("face1");
        }
        public void face2()
        {
            facetwo = true;
            // aRFaceManager = GetComponent<ARFaceManager>();
            //aRFaceManager.facePrefab.GetComponent<MeshRenderer>().material = materials[1];
            //   Debug.Log("face2");
        }
        public void face3()
        {
            facethree = true ;
           // aRFaceManager = GetComponent<ARFaceManager>();
           // aRFaceManager.facePrefab.GetComponent<MeshRenderer>().material = materials[2];
          //  Debug.Log("face3");
        }
    }
}
