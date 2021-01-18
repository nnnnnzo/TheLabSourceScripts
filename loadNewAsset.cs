using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PolyToolkit;
using Photon.Pun;
using Photon.Realtime;
 
public class loadNewAsset : MonoBehaviour {
 
 public int assetCount = 0;
 
 public Transform target;

 public Text searchfield;
 public Text statusText;
 
 public Text SizeInput;

public bool GravitySelected=true;

 
// Reference the text element

      public void ToggleAnalog(){
        GravitySelected = !GravitySelected;
      }


      public void Search() {
            PolyListAssetsRequest req = new PolyListAssetsRequest();
 
            req.keywords = searchfield.text.ToString();
            req.curated = true;
            req.maxComplexity = PolyMaxComplexityFilter.MEDIUM;
            req.orderBy = PolyOrderBy.BEST;
            req.pageSize = 20;
            PolyApi.ListAssets(req, GetDonuts);
            statusText.text = "Requesting...";
      }
      
      private void GetDonuts(PolyStatusOr<PolyListAssetsResult> result) {
        PolyImportOptions options = PolyImportOptions.Default();
        options.rescalingMode = PolyImportOptions.RescalingMode.FIT;
        float Size = float.Parse(SizeInput.text);
        options.desiredSize = Size;
        options.recenter = true;
        List<PolyAsset> assetsInUse = new List<PolyAsset>();
        for (int i = 0; i < Mathf.Min(1, result.Value.assets.Count); i++) {
          statusText.text = "Importing...";
          PolyApi.Import(result.Value.assets[i], options, ImportDonuts);
          assetsInUse.Add(result.Value.assets[i]);
// Update the Attributions Text
        }
      }
      

      private void ImportDonuts(PolyAsset asset, PolyStatusOr<PolyImportResult> result) {
        assetCount++;
        result.Value.gameObject.transform.position = Vector3.MoveTowards(transform.position, target.position, 0);
        if (GravitySelected == true){
            result.Value.gameObject.AddComponent<Rigidbody>();
        }
        else {
          result.Value.gameObject.AddComponent<Rigidbody>().useGravity = false;
        }
        result.Value.gameObject.AddComponent<Rigidbody>();
        result.Value.gameObject.AddComponent<BoxCollider>();
        statusText.text = asset.displayName + "\nby " + asset.authorName;
        //result.Value.gameObject.AddComponent<MeshCollider>().convex = true;
      }
}