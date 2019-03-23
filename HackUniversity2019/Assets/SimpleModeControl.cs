using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleModeControl : MonoBehaviour {
	[SerializeField] Animator camera;
	[SerializeField] VRController Vrcontr;
	public GameObject vostok1;
	public List<GameObject> listArrow=new List<GameObject>();
	public GameObject helpFade;
	public Text desciption;
	public Text desciptionHead;
	public int step;
	// Use this for initialization
	void Start () {
		
	}
	public void NextStep(){
		
		switch (step) {
		case 0:
			vostok1.GetComponent<RootTween> ().enabled = false;
			vostok1.transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));
			camera.enabled = true;
			camera.Play ("CamPos1");
			helpFade.SetActive (false);
			desciptionHead.text = "Антенна связи.";
			desciption.text = "Антенна — устройство, предназначенное для излучения или приёма радиоволн.";
			step++;
			break;
		case 1:
			camera.Play ("CamPos2");
			listArrow [step-1].SetActive (false);
			helpFade.SetActive (false);
			desciptionHead.text = "Баллоны пневмосистмы.";
			desciption.text = "Баллоны пневмосистмы (16 шт.) для системы жизнеобеспечения.";
			step++;
			break;
		case 2:
			camera.Play ("CamPos3");
			listArrow [step-1].SetActive (false);
			helpFade.SetActive (false);
			desciptionHead.text = "Тормозной двигатель.";
			desciption.text = "Затормозить космический корабль, двигающийся по орбите вокруг Земли, можно путем включения двигателя, развивающего тягу, направленную против движения корабля. ";
			step++;
			break;
		case 3:
			camera.Play ("CamPos4");
			listArrow [step-1].SetActive (false);
			helpFade.SetActive (false);
			desciptionHead.text = "Иллюминатор с оптическим ориентиром.";
			desciption.text = "Нужен для ориентации.";
			step++;
			break;
		case 4:
			camera.Play ("CamPos5");
			vostok1.GetComponent<Animator> ().enabled = true;
			vostok1.GetComponent<Animator> ().Play ("Vostok1Dissection");
			listArrow [step-1].SetActive (false);
			helpFade.SetActive (false);
			desciptionHead.text = "Катапультируемое кресло.";
			desciption.text = "«На высоте около 7 км входной люк отстреливался от спускаемого аппарата и кресло с космонавтом катапультировалось. Раскрывался парашют, через некоторое время сбрасывалось кресло, чтобы космонавт не ударился о него при приземлении. »";
			step++;
			break;
		case 5:
			camera.Play ("CamPos6");
			listArrow [step-1].SetActive (false);
			helpFade.SetActive (false);
			desciptionHead.text = "Приборная панель";
			desciption.text = "«В состав аппаратуры космического корабля входили системы автоматического и ручного управления полетом, автоматической ориентации на Солнце, ручной ориентации на Землю, жизнеобеспечения, электропитания...»";
			step++;
			break;
		case 6:
			camera.Play ("CamPos7");
			vostok1.GetComponent<Animator> ().Play ("Vostok1Reload");
			listArrow [step-1].SetActive (false);
			helpFade.SetActive (false);
			desciptionHead.text = "Восток-1";
			desciption.text = "«\"Восток-1\" - корабль, на котором 12 апреля 1961 года совершил свой знаменитый полёт Юрий Алексеевич Гагарин. Длительность полёта составила 1 час 48 минут, за это время был совершён 1 виток вокруг Земли.»";
			step=0;
			break;
		}
	}
	public void EndAnimationMoveCam(){
		helpFade.SetActive (true);
		if (step != 0) {
			listArrow [step - 1].SetActive (true);
		} else {
			
			vostok1.GetComponent<RootTween> ().enabled = true;
		}


	}
	public void exite(){
		Vrcontr.ActiveSimpleMode ();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
