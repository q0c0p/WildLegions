using UnityEngine;
using System.Collections;
using UMA;

public class WildLegionHero : MonoBehaviour {


	public UMAGeneratorBase generator_;
	public SlotLibrary slotLib;
	public OverlayLibrary overlayLib;
	public RaceLibrary raceLib;
	public RuntimeAnimatorController animController;
	
	private UMADynamicAvatar umaDynAvatar;
	private UMAData umaData;
	private UMADnaHumanoid umaDna;
	private UMADnaTutorial umaDnaTutorial;

	private int maxNumOfSlots = 20;

	private Color32 hairColor = new Color32(84,9,42,255);
	private Color32 eyebrowColor = new Color32(53,5,30,255);
	private Color32 tshirtColor = new Color32(67,96,39,255);
	private Color32 jeansColor = new Color32(42,58,31,255);

	// Use this for initialization
	void Start () {
		GenerateUMA ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void GenerateUMA()
	{
		//Create a new game object and UMA components to it 
		GameObject gameObj_ = new GameObject ("MyUMA");
		umaDynAvatar = gameObj_.AddComponent<UMADynamicAvatar> ();
		
		//Initialise Avatar and grab z regerence to it's data component
		umaDynAvatar.Initialize ();
		umaData = umaDynAvatar.umaData;
		
		//Attach the generator
		umaDynAvatar.umaGenerator = generator_;
		umaData.umaGenerator = generator_;
		
		//Set up slot array
		umaData.umaRecipe.slotDataList = new SlotData[maxNumOfSlots];
		
		//Set up our Morph references
		umaDna = new UMADnaHumanoid();
		umaDnaTutorial = new UMADnaTutorial ();
		umaData.umaRecipe.AddDna (umaDna);
		umaData.umaRecipe.AddDna (umaDnaTutorial);
		
		//create UMA character + animator controller
		CreateFemale ();
		
		umaDynAvatar.animationController = animController;
		
		//attach the MyUMA object to the object (eg player) which this script is attached to
		gameObj_.transform.parent = this.gameObject.transform;
		gameObj_.transform.localPosition = Vector3.zero;
		gameObj_.transform.localRotation = Quaternion.identity;
		
		//generate the UMA
		umaDynAvatar.UpdateNewRace ();
	}
	
	void CreateFemale()
	{
		//grab a reference to our recipe
		var umaRecipe = umaDynAvatar.umaData.umaRecipe;
		umaRecipe.SetRace (raceLib.GetRace ("HumanFemale"));
		//eyes
		AddSlot(0,"FemaleEyes");
		AddOverlay (0, "EyeOverlay", Color.gray);
		AddOverlay (0,"EyeOverlayAdjust");
		//inner mouth
		AddSlot (1,"FemaleInnerMouth");
		AddOverlay (1,"InnerMouth");
		//face
		AddSlot (2,"FemaleFace");
		AddOverlay (2,"FemaleHead01");
		//torso
		AddSlot (3,"FemaleTorso");
		AddOverlay (3,"FemaleBody02");
		umaDna.breastSize = 0.350f;
		//hands
		AddSlot (4,"FemaleHands");
		LinkOverlay(4,3);
		//legs
		AddSlot (5,"FemaleLegs");
		LinkOverlay (5, 3);
		//feet
		AddSlot (6,"MSimpleLeatherShoes");
		AddOverlay(6,"MSimpleLeatherShoes");
		
		// underwear
		AddOverlay (3,"FemaleUnderwear01",Color.black);
		//Tshirt
		AddOverlay (3, "FemaleShirt01" ,tshirtColor);
		//Jeans
		AddOverlay (5, "FemaleJeans01",jeansColor);

		
		//eyebrows
		AddOverlay (2,"FemaleEyebrow01",eyebrowColor);	
		//eyelash
		AddSlot (7, "FemaleEyelash");
		AddOverlay (7, "FemaleEyelash",Color.black);
		
		//hair
		AddSlot (8, "M_Hair_Shaggy");
		AddOverlay (8, "M_Hair_Shaggy",hairColor);
		
	}


	//************** Slot helpers ******
	
	void AddSlot(int number, string slotname)
	{
		umaData.umaRecipe.slotDataList[number] = slotLib.InstantiateSlot (slotname);
	}
	
	void RemoveSlot(int slotnumber)
	{
		umaData.umaRecipe.slotDataList[slotnumber] = null;
	}
	
	//Overlay helpers
	
	void AddOverlay(int number, string overlayname)
	{
		umaData.umaRecipe.slotDataList [number].AddOverlay (overlayLib.InstantiateOverlay (overlayname));	
	}
	
	void AddOverlay(int number, string overlayname, Color color)
	{
		umaData.umaRecipe.slotDataList [number].AddOverlay (overlayLib.InstantiateOverlay (overlayname, color));	
	}
	
	void LinkOverlay (int slotNumber, int slotToLink)
	{
		umaData.umaRecipe.slotDataList [slotNumber].SetOverlayList (umaData.umaRecipe.slotDataList[slotToLink].GetOverlayList());
	}
	
	void RemoveOverlay(int slot, string overlayname)
	{
		umaData.umaRecipe.slotDataList [slot].RemoveOverlay (overlayname);
	}
	
	void ColorOverlay (int slotnum, string overlayname, Color color)
	{	
		umaData.umaRecipe.slotDataList [slotnum].SetOverlayColor (color, overlayname);
	}
}
