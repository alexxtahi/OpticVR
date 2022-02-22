using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
using System.Text;
//using System.Windows.Forms;
public class Bouge : MonoBehaviour

{

    

    public TextMeshPro textmesh;
    public TextMeshPro textme;
    public TextMeshPro textme1;
    public TextMeshPro textme2;
    public TextMeshPro textme3;
    public TextMeshPro textme4;
    public TextMeshPro textme5;
    public TextMeshPro textme6;
    public TextMeshPro textme7;
    public TextMeshPro textme8;
    public TextMeshPro textme9;


    public float timer;
    public GameObject give1;
    public GameObject give2;
    public GameObject give3;
    public GameObject give4;
    public GameObject give5;
    public GameObject give6;
    public GameObject give7;
    public GameObject give8;
    public GameObject give9;
    public GameObject give10;

    public List<string> myList;
    public List<string> myList1;
    public List<string> myList2;
    public List<string> myList3;
    public List<string> myList4;
    public List<string> myList5;
    public List<string> myList6;
    public List<string> myList7;
    public List<string> myList8;
    public List<string> myList9;
    public List<string> myList10;




    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        timer +=Time.deltaTime;


    }
    public void OnButtonClicked()
    {
        print("The button has clicked!");
    }

    void OnGUI(){ 
        float minutes = Mathf.Floor(timer%60);
        float deadline1 = 0;
        float deadline2 = 7;
        float deadline3 = 14;
        float deadline4 = 20;
        float deadline5 = 27;
        float deadline6 = 34;
        float deadline7 = 39;
        float deadline8 = 45;
        float deadline9 = 50;
        float deadline0 = 55;
        float deadline01 = 58;

        //Traitement première ligne 

        textmesh = GetComponent<TextMeshPro>();
        //print(textmesh.text);
        string change =textmesh.text;
        foreach (var item in change)
        {
            myList.Add(item.ToString());
        }


        //Traitement deuxième ligne

        give1 = GameObject.Find("TOZ");
        textme=give1.GetComponent<TextMeshPro>();
        string change1 =textme.text;
        foreach (var items in change1)
        {
            myList1.Add(items.ToString());
        }

        //Traitement troisième ligne
        give2 = GameObject.Find("LPED");
        textme1=give2.GetComponent<TextMeshPro>();
        string change2 =textme1.text;
        foreach (var item1 in change2)
        {
            myList2.Add(item1.ToString());
        }

        //Traitement quatrième ligne
        give3 = GameObject.Find("PECFED");
        textme2=give3.GetComponent<TextMeshPro>();
        string change3= textme2.text;
        foreach (var item2 in change3)
        {
            myList3.Add(item2.ToString());
        }

        //Traitement cinquième ligne
        give4 = GameObject.Find("EDFCZP");
        textme3=give4.GetComponent<TextMeshPro>();
        string change4= textme3.text;
        foreach (var item3 in change4)
        {
            myList4.Add(item3.ToString());
        }

        //Traitement sixième ligne
        give5 = GameObject.Find("FELOPZD");
        textme4=give5.GetComponent<TextMeshPro>();
        string change5= textme4.text;
        foreach (var item4 in change5)
        {
            myList5.Add(item4.ToString());
        }

        //Traitement septième ligne
        give6 = GameObject.Find("DEFPOTEC");
        textme5=give6.GetComponent<TextMeshPro>();
        string change6= textme5.text;
        foreach (var item5 in change6)
        {
            myList6.Add(item5.ToString());
        }

        //Traitement huitième ligne
        give7 = GameObject.Find("LEFOTPCD");
        textme6=give7.GetComponent<TextMeshPro>();
        string change7= textme6.text;
        foreach (var item6 in change7)
        {
            myList7.Add(item6.ToString());
        }

        //Traitement neuvième ligne
        give8 = GameObject.Find("FDPLTCEO");
        textme7=give8.GetComponent<TextMeshPro>();
        string change8=textme7.text;
        foreach (var item7 in change8)
        {
            myList8.Add(item7.ToString());
        }

        //Traitement dixième
        give9 = GameObject.Find("PEZO");
        textme8=give9.GetComponent<TextMeshPro>();
        string change9=textme8.text;
        foreach (var item8 in change9)
        {
            myList9.Add(item8.ToString());
        }
        
        //Traitement Button A
        /*give10 =GameObject.Find("A");
        Button buttonComponent = GetComponent<Button>();
        buttonComponent.onClick.AddListener(OnButtonClicked);*/


        

        //print(minutes);
   
        if(minutes>deadline1 && minutes<deadline2){
            string rog19 = myList9[0]+myList9[1]+myList9[2]+myList9[3]+myList9[4]+myList9[5]+myList9[6]+myList9[7]+
            myList9[8]+myList9[9]+myList9[10]+myList9[11]+"<color=white>"+myList9[12]+"</color>"+myList9[13]+myList9[14];
            textme8.text = rog19;
        
            string rog = "<color=red>"+myList[0]+"</color>"+myList[1]+myList[2]+myList[3];
            textmesh.text = rog;
            //print(myList[3]);
         
            
        }
        else if(minutes>deadline2 && minutes<deadline3)
        {
            string rog1 = "<color=white>"+myList[0]+"</color>"+myList[1]+myList[2]+myList[3];
            textmesh.text = rog1;
            string rog2 = myList1[0]+myList1[1]+myList1[2]+"<color=red>"+myList1[3]+"</color>"+myList1[4]+myList1[5]+myList1[6];
            textme.text = rog2;
        }
        else if(minutes>deadline3 && minutes<deadline4)
        {
            string rog3 = myList1[0]+myList1[1]+myList1[2]+"<color=white>"+myList1[3]+"</color>"+myList1[4]+myList1[5]+myList1[6];
            textme.text = rog3;
            string rog4 = myList2[0]+myList2[1]+myList2[2]+"<color=red>"+myList2[3]+"</color>"+myList2[4]+myList2[5]+myList2[6]+myList2[7]+myList2[8]+myList2[9];
            textme1.text = rog4;
            
        }
        else if(minutes>deadline4 && minutes<deadline5)
        {
            string rog5 = myList2[0]+myList2[1]+myList2[2]+"<color=white>"+myList2[3]+"</color>"+myList2[4]+myList2[5]+myList2[6]+myList2[7]+myList2[8]+myList2[9];
            textme1.text = rog5;
            string rog6 = myList3[0]+myList3[1]+myList3[2]+myList3[3]+myList3[4]+myList3[5]+myList3[6]+myList3[7]+
            myList3[8]+myList3[9]+"<color=red>"+myList3[10]+"</color>";
            textme2.text = rog6;
          
        }
        else if(minutes>deadline5 && minutes<deadline6)
        {
            string rog7 = myList3[0]+myList3[1]+myList3[2]+myList3[3]+myList3[4]+myList3[5]+myList3[6]+myList3[7]+
            myList3[8]+myList3[9]+"<color=white>"+myList3[10]+"</color>";
            textme2.text = rog7;
            string rog8 = "<color=red>"+myList4[0]+"</color>"+myList4[1]+myList4[2]+myList4[3]+myList4[4]+myList4[5]+myList4[6]+myList4[7]+
            myList4[8]+myList4[9]+myList4[10];
            textme3.text = rog8;
  
        }
        else if(minutes>deadline6 && minutes<deadline7)
        {
            string rog9 = "<color=white>"+myList4[0]+"</color>"+myList4[1]+myList4[2]+myList4[3]+myList4[4]+myList4[5]+myList4[6]+myList4[7]+
            myList4[8]+myList4[9]+myList4[10];
            textme3.text = rog9;
            string rog10 = myList5[0]+myList5[1]+myList5[2]+myList5[3]+myList5[4]+myList5[5]+"<color=red>"+myList5[6]+"</color>"+myList5[7]+
            myList5[8]+myList5[9]+myList5[10]+myList5[11]+myList5[12];
            textme4.text = rog10;
       
        }
        else if(minutes>deadline7 && minutes<deadline8)
        {
            string rog11 = myList5[0]+myList5[1]+myList5[2]+myList5[3]+myList5[4]+myList5[5]+"<color=white>"+myList5[6]+"</color>"+myList5[7]+
            myList5[8]+myList5[9]+myList5[10]+myList5[11]+myList5[12];
            textme4.text = rog11;
            string rog12 = myList6[0]+myList6[1]+myList6[2]+myList6[3]+myList6[4]+myList6[5]+myList6[6]+myList6[7]+
            myList6[8]+myList6[9]+"<color=red>"+myList6[10]+"</color>"+myList6[11]+myList6[12]+myList6[13]+myList6[14];
            textme5.text = rog12;
 
        }
        else if(minutes>deadline8 && minutes<deadline9)
        {
            string rog13 = myList6[0]+myList6[1]+myList6[2]+myList6[3]+myList6[4]+myList6[5]+myList6[6]+myList6[7]+
            myList6[8]+myList6[9]+"<color=white>"+myList6[10]+"</color>"+myList6[11]+myList6[12]+myList6[13]+myList6[14];
            textme5.text = rog13;
            string rog14 = "<color=red>"+myList7[0]+"</color>"+myList7[1]+myList7[2]+myList7[3]+myList7[4]+myList7[5]+myList7[6]+myList7[7]+
            myList7[8]+myList7[9]+myList7[10]+myList7[11]+myList7[12]+myList7[13]+myList7[14];
            textme6.text = rog14;
        
        }
        else if(minutes>deadline9 && minutes<deadline0)
        {
            string rog15 = "<color=white>"+myList7[0]+"</color>"+myList7[1]+myList7[2]+myList7[3]+myList7[4]+myList7[5]+myList7[6]+myList7[7]+
            myList7[8]+myList7[9]+myList7[10]+myList7[11]+myList7[12]+myList7[13]+myList7[14];
            textme6.text = rog15;
            string rog16 = myList8[0]+myList8[1]+myList8[2]+myList8[3]+myList8[4]+myList8[5]+myList8[6]+myList8[7]+
            myList8[8]+myList8[9]+myList8[10]+myList8[11]+myList8[12]+myList8[13]+"<color=red>"+myList8[14]+"</color>";
            textme7.text = rog16;

        }

        else if(minutes>deadline0 && minutes<deadline01)
        {
            string rog17 = myList8[0]+myList8[1]+myList8[2]+myList8[3]+myList8[4]+myList8[5]+myList8[6]+myList8[7]+
            myList8[8]+myList8[9]+myList8[10]+myList8[11]+myList8[12]+myList8[13]+"<color=white>"+myList8[14]+"</color>";
            textme7.text = rog17;
            string rog18 = myList9[0]+myList9[1]+myList9[2]+myList9[3]+myList9[4]+myList9[5]+myList9[6]+myList9[7]+
            myList9[8]+myList9[9]+myList9[10]+myList9[11]+"<color=red>"+myList9[12]+"</color>"+myList9[13]+myList9[14];
            textme8.text = rog18;
        } 
    }
}
