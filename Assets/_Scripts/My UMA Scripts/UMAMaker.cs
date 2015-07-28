using UnityEngine;
using System.Collections;
using UMA;
using System.IO;

public class UMAMaker : MonoBehaviour {

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

	// body parameters
	[Range (0.0f,1.0f)]
	public float bodymass = 0.5f;

	public bool hairState = false;
	private bool lastHairState = false;

	public Color hairColor;
	private Color lastHairColor;

	public bool browState = false;
	private bool lastbrowState = false;
	
	public Color browColor;
	private Color lastbrowColor;

	// clothing parameters
	public bool vestState = false;
	private bool lastVestState =  false;
	public Color vestColor = Color.white;
	private Color lastVestColor = Color.white;

	public bool jeanState = false;
	private bool lastjeanState =  false;
	public Color jeanColor ;
	private Color lastjeanColor;


	public string saveString = "";
	public bool save;
	public bool load;

	void Start()
	{
		GenerateUMA ();
	}

	void Update()
	{
		if (bodymass != umaDna.upperMuscle) {
			SetBodyMass (bodymass);
			umaData.isShapeDirty = true;
			umaData.Dirty ();
		}

		if (vestState && !lastVestState) {
			lastVestState =true;
			AddOverlay (3, "FemaleShirt01" ,vestColor);
			umaData.isTextureDirty = true;
			umaData.Dirty ();
		}
		if (!vestState && lastVestState) {
			lastVestState =false;
			RemoveOverlay(3,"FemaleShirt01");
			umaData.isTextureDirty = true;
			umaData.Dirty ();
		}

		if (vestColor != lastVestColor && vestState) {
			lastVestColor = vestColor;
			ColorOverlay(3,"FemaleShirt01",vestColor);
			umaData.isTextureDirty = true;
			umaData.Dirty ();
		}

		if (hairState && !lastHairState) {
			lastHairState = hairState;
			AddSlot(8,"M_Hair_Shaggy");
			AddOverlay(8,"M_Hair_Shaggy",hairColor);
			umaData.isMeshDirty = true;
			umaData.isTextureDirty = true;
			umaData.isShapeDirty = true;
			
			umaData.Dirty ();
		}
		if (!hairState && lastHairState) {
			lastHairState = hairState;
			RemoveOverlay(8,"M_Hair_Shaggy");
			RemoveSlot(8);

			umaData.isMeshDirty = true;
			umaData.isTextureDirty = true;
			umaData.isShapeDirty = true;
			
			umaData.Dirty ();
		}

		if (hairColor != lastHairColor && hairState) {
			lastHairColor = hairColor;
			ColorOverlay(8,"M_Hair_Shaggy",hairColor);
			umaData.isTextureDirty = true;
			umaData.Dirty ();
		}

		if (browState && !lastbrowState) {
			lastbrowState = browState;
			AddOverlay (2,"FemaleEyebrow01",browColor);
			umaData.isTextureDirty = true;
			umaData.Dirty ();
		}
		if (!browState && lastbrowState) {
			lastbrowState = browState;
			RemoveOverlay(2,"FemaleEyebrow01");
					
			umaData.isTextureDirty = true;
			umaData.Dirty ();
		}
		
		if (browColor != lastbrowColor && browState) {
			lastbrowColor = browColor;
			ColorOverlay(2,"FemaleEyebrow01",jeanColor);
			umaData.isTextureDirty = true;
			umaData.Dirty ();
		}

		if (jeanState && !lastjeanState) {
			lastjeanState = jeanState;
			AddOverlay (5, "FemaleJeans01",jeanColor);
			umaData.isTextureDirty = true;
			umaData.Dirty ();
		}
		if (!jeanState && lastjeanState) {
			lastjeanState = jeanState;
			RemoveOverlay(5, "FemaleJeans01");
			
			umaData.isTextureDirty = true;
			umaData.Dirty ();
		}
		
		if (jeanColor != lastjeanColor && jeanState) {
			lastjeanColor = jeanColor;
			ColorOverlay(5, "FemaleJeans01",jeanColor);
			umaData.isTextureDirty = true;
			umaData.Dirty ();
		}

		/*if (save) {
			save =false;
			Save ();
		}
		if (load) {
			load =false;
			Load ();
		}*/
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
		//hands
		AddSlot (4,"FemaleHands");
		LinkOverlay(4,3);
		//legs
		AddSlot (5,"FemaleLegs");
		LinkOverlay (5, 3);
		//feet
		AddSlot (6,"FemaleFeet");
		LinkOverlay (6, 3);
		
		// underwear
		AddOverlay (3,"FemaleUnderwear01");
			
		//eyebrows
		AddOverlay (2,"FemaleEyebrow01",browColor);	
		
		AddSlot (7, "FemaleHead_Eyes");
		
		//hair
		AddSlot (8, "M_Hair_Shaggy");
		AddOverlay (8, "M_Hair_Shaggy",hairColor);

		//Tshirt
		//AddOverlay (3, "FemaleShirt01" ,vestColor);
		//Jeans

		AddOverlay (5, "FemaleJeans01");

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

	//********************Morph Routines*******************************

	//set the overall body mass (mass value must be betwteen 0 and 1) : skinny to strong 
	void SetBodyMass (float mass)
	{
		umaDna.upperMuscle = mass;
		umaDna.upperWeight = mass;
		umaDna.lowerMuscle = mass;
		umaDna.lowerWeight = mass;
		umaDna.armWidth = mass;
		umaDna.forearmWidth = mass;
			
	}

	//*************** Load and Save ****************************************
	/*
	//here we save the UMA character as a string into a txt file
	void Save()
	{
		//Generate UMA String
		UMATextRecipe recipe = ScriptableObject.CreateInstance<UMATextRecipe> ();
		recipe.Save (umaDynAvatar.umaData.umaRecipe, umaDynAvatar.context);
		saveString = recipe.recipeString;
		Destroy (recipe);

		//Save this string to txt file
		string filename = "AssetTest.txt";
		StreamWriter stream = File.CreateText (filename);
		stream.WriteLine (saveString);
		stream.Close ();
	}

	void Load()
	{
		//Load string from text file
		string filename = "AssetTest.txt";
		StreamReader stream = File.OpenText (filename);
		saveString = stream.ReadLine ();
		stream.Close ();

		//Regenerate UMA using string
		UMATextRecipe recipe = ScriptableObject.CreateInstance<UMATextRecipe>();
		recipe.recipeString = saveString;
		umaDynAvatar.Load (recipe);
		Destroy (recipe);
	}
	*/
}
