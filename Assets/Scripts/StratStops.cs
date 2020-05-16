using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StratStops : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator mainCam;
    public AudioSource main_cam;
    public Animator tami;
    public Animator hika_cen;
    public Animator ed;
    public Animator ed_text;
    public Animator lyl_text;
    public Animator con_phra_txt;
    public Animator cars;
    public GameObject newchara_line;

    void Start()
    {
        //print("jjjijjjjijijij");
      mainCam.enabled = false;
        main_cam.enabled = false;
      tami.enabled = false;
      hika_cen.enabled = false;
        ed.enabled = false;
        ed_text.enabled = false;
        lyl_text.enabled = false;
        con_phra_txt.enabled = false;
        cars.enabled = false;
       // print(main_cam.enabled);
      Invoke("ReStart", 2f);
    }

    void ReStart(){
        //print("kokokko");
      mainCam.enabled = true;
      tami.enabled = true;
      hika_cen.enabled = true;
        main_cam.enabled = true;
        ed.enabled = true;
        ed_text.enabled = true;
        lyl_text.enabled = true;
        con_phra_txt.enabled = true;
        cars.enabled = true;
    }

    public void newcharaIsOn(){
        newchara_line.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //newchara_line.SetActive(true);
    }
}
