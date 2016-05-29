using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UIManagePhoneDetailScript : MonoBehaviour {
	public AudioClip frog;
	public AudioClip horse;
	public AudioClip sheep;
	public AudioClip cow;
	public AudioClip duck;
	public AudioClip turkey;
	public AudioClip coat;
	public AudioClip chicken;
	public AudioClip dog;
	public Text text; 
	public Image image; 
		//songs
	public AudioClip[] clips;
//	public string[] strings= new string[]{"Five Little Ducks","Crooked Man","Hickory Dickory","If you are happy","Old MacDonald"};
//	public string[] images2= new string[]{"in_call_feature_five_little_ducks","in_call_feature_crooked_man","in_call_feature_hickory","in_call_feature_if_you_are_happy","in_call_feature_old_macdonald"};
	private string[] strings= new string[]{"Christmas Bell","Deck The Halls","Feliz Havidad","Frosty The Snowman","Hark The Herald Angels Sing","Jingle Bells","Kris Kringle","Ring The Bells","Rudolph The Red Nose Reindeer","Santa Claus Is Coming To Town","Sleigh Ride","The First Noel","The Twelve Days Of Christmas","Up On The HouseTop"};
	private string[] images2= new string[]{"christmas_bells","deck_the_halls","feliz_navidad","fronsty_the_snowman","hark_the_herald","jingle_bells","kris_kringle2","jingle_bells","santa_sleigh_and_reindeer","santa_and_reindeer","santa_sleigh_and_reindeer","feliz_navidad","the_twelve_days_of_christmas","jingle_bells"};
	public AudioSource source;
	private bool isStop=false;
	// Use this for initialization
	void Start () {
		int index = Random.Range (0, clips.Length - 1);
		source.PlayOneShot(clips[index]);
		text.text = strings[index];
//		image.name = images [index];
		Sprite newSprite =  Resources.Load <Sprite>(images2[index]);
		Debug.Log ("load "+images2[index]);
		if (newSprite){
			image.sprite = newSprite;
		} else {
			Debug.LogError("Sprite not found", this);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			source.Stop ();
			isStop=true;
		}
		if (isStop == true) {
			if(Application.CanStreamedLevelBeLoaded(1)){
				isStop=false;
				Application.LoadLevelAdditive(1);
			}
		}
	}
	public void btnEndClicked()
	{
		source.Stop ();
		Handheld.Vibrate();
		isStop = true;
//		Application.LoadLevel("Phone");
	}
	public void btnDetail1Clicked()
	{
		source.PlayOneShot (cow);
		Handheld.Vibrate();
	}
	public void btnDetail2Clicked()
	{
		source.PlayOneShot (dog);
		Handheld.Vibrate();
	}
	public void btnDetail3Clicked()
	{
		source.PlayOneShot (duck);
		Handheld.Vibrate();
	}
	public void btnDetail4Clicked()
	{
		source.PlayOneShot (coat);
		Handheld.Vibrate();
	}
	public void btnDetail5Clicked()
	{
		source.PlayOneShot (horse);
		Handheld.Vibrate();
	}
	public void btnDetail6Clicked()
	{
		source.PlayOneShot (chicken);
		Handheld.Vibrate();
	}
	public void btnDetail7Clicked()
	{
		source.PlayOneShot (sheep);
		Handheld.Vibrate();
	}
	public void btnDetail8Clicked()
	{
		source.PlayOneShot (frog);
		Handheld.Vibrate();
	}
	public void btnDetail9Clicked()
	{
		source.PlayOneShot (turkey);
		Handheld.Vibrate();
	}
}
