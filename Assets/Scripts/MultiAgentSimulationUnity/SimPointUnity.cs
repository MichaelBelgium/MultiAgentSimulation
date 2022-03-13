using UnityEngine;

public class SimPointUnity : MonoBehaviour
{
	public SimPoint point;
	
	private Transform p;
	
	public void Init(SimPoint point)
	{
		this.point = point;
		
		gameObject.name = "Point-" + point.id;
		
		p = GameObject.CreatePrimitive(PrimitiveType.Sphere).transform;
		p.parent = transform;
		p.GetComponent<Renderer>().sharedMaterial = MaterialsFactory.CreateDiffuseColor(0xFF0000);
		
		p.localPosition = point.worldPosition;
	}
}


