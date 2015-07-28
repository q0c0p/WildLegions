using UnityEngine;
using System.Collections;
using System.Text;

public class DemoCharacterDetails : MonoBehaviour {

	public void CharacterUpdated(UMA.UMAData umaData)
	{
		var sb = new StringBuilder();
		sb.AppendFormat("Vertices {0} Bones {1}\n", umaData.myRenderer.sharedMesh.vertexCount, umaData.myRenderer.bones.Length);
		
		foreach (var mat in umaData.myRenderer.sharedMaterials)
		{
			sb.AppendFormat("{0} {1}x{2}\n", mat.name, mat.mainTexture.width, mat.mainTexture.height);
		}
		GetComponent<UnityEngine.UI.Text>().text = sb.ToString();
	}
}
