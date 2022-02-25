using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace OpticVR
{
    public class Keyboard : MonoBehaviour
    {
        private Button button;
        private Button pass;
        private TextMeshProUGUI buttonText;
        private TextMeshProUGUI passText;
        private TextMeshProUGUI screenText;
        private TextMeshProUGUI resultatText;

        public static int entre1 = 0;
        public static int entre2 = 0;
        public static int entre3 = 0;
        public static int entre4 = 0;
        public static int entre5 = 0;
        public static int entre6 = 0;
        public static int entre7 = 0;
        public static int entre8 = 0;
        public static int entre9 = 0;
        public static int entre10 = 0;

        //Declaration variable
        private TextMeshPro textme;
        private TextMeshPro textme1;
        private TextMeshPro textme2;
        private TextMeshPro textme3;
        private TextMeshPro textme4;
        private TextMeshPro textme5;
        private TextMeshPro textme6;
        private TextMeshPro textme7;
        private TextMeshPro textme8;

        private GameObject give1;
        private GameObject give2;
        private GameObject give3;
        private GameObject give4;
        private GameObject give5;
        private GameObject give6;
        private GameObject give7;
        private GameObject give8;
        private GameObject give9;

        private List<string> myList = new List<string>();
        private List<string> myList1 = new List<string>();
        private List<string> myList2 = new List<string>();
        private List<string> myList3 = new List<string>();
        private List<string> myList4 = new List<string>();
        private List<string> myList5 = new List<string>();
        private List<string> myList6 = new List<string>();
        private List<string> myList7 = new List<string>();
        private List<string> myList8 = new List<string>();
        private List<string> myList9 = new List<string>();

        public TextMeshPro textmesh;
        public GameObject give0;
        public static bool etat1 = false;
        public static bool etat2 = false;
        public static bool etat3 = false;
        public static bool etat4 = false;
        public static bool etat5 = false;
        public static bool etat6 = false;
        public static bool etat7 = false;
        public static bool etat8 = false;
        public static bool etat9 = false;
        public static bool etat10 = false;


        private void Awake()
        {
            button = gameObject.GetComponent<Button>();
            pass = gameObject.GetComponent<Button>();
            buttonText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
            passText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
            screenText = GameObject.Find("KeyboardScreenContent").GetComponent<TextMeshProUGUI>();
            resultatText = GameObject.Find("Result").GetComponent<TextMeshProUGUI>();


            //Changement Effectué non fini

            //Traitement première ligne 

            give0 = GameObject.Find("FP");
            textmesh = give0.GetComponent<TextMeshPro>();
            string change = null;
            change = textmesh.text;
            foreach (var item in change)
            {
                myList.Add(item.ToString());
            }


            //Traitement deuxième ligne

            give1 = GameObject.Find("TOZ");
            textme = give1.GetComponent<TextMeshPro>();
            string change1 = textme.text;
            foreach (var items in change1)
            {
                myList1.Add(items.ToString());
            }

            //Traitement troisième ligne
            give2 = GameObject.Find("LPED");
            textme1 = give2.GetComponent<TextMeshPro>();
            string change2 = textme1.text;
            foreach (var item1 in change2)
            {
                myList2.Add(item1.ToString());
            }

            //Traitement quatrième ligne
            give3 = GameObject.Find("PECFED");
            textme2 = give3.GetComponent<TextMeshPro>();
            string change3 = textme2.text;
            foreach (var item2 in change3)
            {
                myList3.Add(item2.ToString());
            }

            //Traitement cinquième ligne
            give4 = GameObject.Find("EDFCZP");
            textme3 = give4.GetComponent<TextMeshPro>();
            string change4 = textme3.text;
            foreach (var item3 in change4)
            {
                myList4.Add(item3.ToString());
            }

            //Traitement sixième ligne
            give5 = GameObject.Find("FELOPZD");
            textme4 = give5.GetComponent<TextMeshPro>();
            string change5 = textme4.text;
            foreach (var item4 in change5)
            {
                myList5.Add(item4.ToString());
            }

            //Traitement septième ligne
            give6 = GameObject.Find("DEFPOTEC");
            textme5 = give6.GetComponent<TextMeshPro>();
            string change6 = textme5.text;
            foreach (var item5 in change6)
            {
                myList6.Add(item5.ToString());
            }

            //Traitement huitième ligne
            give7 = GameObject.Find("LEFOTPCD");
            textme6 = give7.GetComponent<TextMeshPro>();
            string change7 = textme6.text;
            foreach (var item6 in change7)
            {
                myList7.Add(item6.ToString());
            }

            //Traitement neuvième ligne
            give8 = GameObject.Find("FDPLTCEO");
            textme7 = give8.GetComponent<TextMeshPro>();
            string change8 = textme7.text;
            foreach (var item7 in change8)
            {
                myList8.Add(item7.ToString());
            }

            //Traitement dixième
            give9 = GameObject.Find("PEZO");
            textme8 = give9.GetComponent<TextMeshPro>();
            string change9 = textme8.text;
            foreach (var item8 in change9)
            {
                myList9.Add(item8.ToString());
            }



            //Fin Changement Effectué
        }
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Button " + buttonText.text + " has been initialized");
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void PressButton()
        {
            Debug.Log("button " + buttonText.text + " pressed");
            // Call onClick event of this button
            button.onClick.Invoke();

            //Commencement nouvelle etape
            if (buttonText.text == "Commencer")
            {
                Resclear();
                string rog = "<color=red>" + myList[0] + "</color>" + myList[1] + myList[2] + myList[3];
                textmesh.text = rog;
                etat1 = true;

            }


            else if (buttonText.text == "F" && etat1 == true)
            {
                etat1 = false;
                string rog1 = "<color=white>" + myList[0] + "</color>" + myList[1] + myList[2] + myList[3];
                textmesh.text = rog1;
                string rog2 = myList1[0] + myList1[1] + myList1[2] + "<color=red>" + myList1[3] + "</color>" + myList1[4] + myList1[5] + myList1[6];
                textme.text = rog2;
                entre1 = 1;
                etat2 = true;


            }
            else if (buttonText.text == "O" && etat2 == true)
            {
                etat2 = false;
                string rog3 = myList1[0] + myList1[1] + myList1[2] + "<color=white>" + myList1[3] + "</color>" + myList1[4] + myList1[5] + myList1[6];
                textme.text = rog3;
                string rog4 = myList2[0] + myList2[1] + myList2[2] + "<color=red>" + myList2[3] + "</color>" + myList2[4] + myList2[5] + myList2[6] + myList2[7] + myList2[8] + myList2[9];
                textme1.text = rog4;
                entre2 = 1;
                etat3 = true;


            }
            else if (buttonText.text == "P" && etat3 == true)
            {
                etat3 = false;
                string rog5 = myList2[0] + myList2[1] + myList2[2] + "<color=white>" + myList2[3] + "</color>" + myList2[4] + myList2[5] + myList2[6] + myList2[7] + myList2[8] + myList2[9];
                textme1.text = rog5;
                string rog6 = myList3[0] + myList3[1] + myList3[2] + myList3[3] + myList3[4] + myList3[5] + myList3[6] + myList3[7] +
                myList3[8] + myList3[9] + "<color=red>" + myList3[10] + "</color>";
                textme2.text = rog6;
                entre3 = 1;
                etat4 = true;


            }
            else if (buttonText.text == "D" && etat4 == true)
            {
                etat4 = false;
                string rog7 = myList3[0] + myList3[1] + myList3[2] + myList3[3] + myList3[4] + myList3[5] + myList3[6] + myList3[7] +
                myList3[8] + myList3[9] + "<color=white>" + myList3[10] + "</color>";
                textme2.text = rog7;
                string rog8 = "<color=red>" + myList4[0] + "</color>" + myList4[1] + myList4[2] + myList4[3] + myList4[4] + myList4[5] + myList4[6] + myList4[7] +
                myList4[8] + myList4[9] + myList4[10];
                textme3.text = rog8;
                entre4 = 1;
                etat5 = true;

            }
            else if (buttonText.text == "E" && etat5 == true)
            {
                etat5 = false;
                string rog9 = "<color=white>" + myList4[0] + "</color>" + myList4[1] + myList4[2] + myList4[3] + myList4[4] + myList4[5] + myList4[6] + myList4[7] +
                myList4[8] + myList4[9] + myList4[10];
                textme3.text = rog9;
                string rog10 = myList5[0] + myList5[1] + myList5[2] + myList5[3] + myList5[4] + myList5[5] + "<color=red>" + myList5[6] + "</color>" + myList5[7] +
                myList5[8] + myList5[9] + myList5[10] + myList5[11] + myList5[12];
                textme4.text = rog10;
                entre5 = 1;
                etat6 = true;

            }
            else if (buttonText.text == "M" && etat6 == true)
            {
                etat6 = false;
                string rog11 = myList5[0] + myList5[1] + myList5[2] + myList5[3] + myList5[4] + myList5[5] + "<color=white>" + myList5[6] + "</color>" + myList5[7] +
                myList5[8] + myList5[9] + myList5[10] + myList5[11] + myList5[12];
                textme4.text = rog11;
                string rog12 = myList6[0] + myList6[1] + myList6[2] + myList6[3] + myList6[4] + myList6[5] + myList6[6] + myList6[7] +
                myList6[8] + myList6[9] + "<color=red>" + myList6[10] + "</color>" + myList6[11] + myList6[12] + myList6[13] + myList6[14];
                textme5.text = rog12;
                entre6 = 1;
                etat7 = true;

            }
            else if (buttonText.text == "T" && etat7 == true)
            {
                etat7 = false;
                string rog13 = myList6[0] + myList6[1] + myList6[2] + myList6[3] + myList6[4] + myList6[5] + myList6[6] + myList6[7] +
                myList6[8] + myList6[9] + "<color=white>" + myList6[10] + "</color>" + myList6[11] + myList6[12] + myList6[13] + myList6[14];
                textme5.text = rog13;
                string rog14 = "<color=red>" + myList7[0] + "</color>" + myList7[1] + myList7[2] + myList7[3] + myList7[4] + myList7[5] + myList7[6] + myList7[7] +
                myList7[8] + myList7[9] + myList7[10] + myList7[11] + myList7[12] + myList7[13] + myList7[14];
                textme6.text = rog14;
                entre7 = 1;
                etat8 = true;
            }
            else if (buttonText.text == "L" && etat8 == true)
            {
                etat8 = false;
                string rog15 = "<color=white>" + myList7[0] + "</color>" + myList7[1] + myList7[2] + myList7[3] + myList7[4] + myList7[5] + myList7[6] + myList7[7] +
                myList7[8] + myList7[9] + myList7[10] + myList7[11] + myList7[12] + myList7[13] + myList7[14];
                textme6.text = rog15;
                string rog16 = myList8[0] + myList8[1] + myList8[2] + myList8[3] + myList8[4] + myList8[5] + myList8[6] + myList8[7] +
                myList8[8] + myList8[9] + myList8[10] + myList8[11] + myList8[12] + myList8[13] + "<color=red>" + myList8[14] + "</color>";
                textme7.text = rog16;
                entre8 = 1;
                etat9 = true;

            }

            else if (buttonText.text == "Q" && etat9 == true)
            {
                etat9 = false;
                string rog17 = myList8[0] + myList8[1] + myList8[2] + myList8[3] + myList8[4] + myList8[5] + myList8[6] + myList8[7] +
                myList8[8] + myList8[9] + myList8[10] + myList8[11] + myList8[12] + myList8[13] + "<color=white>" + myList8[14] + "</color>";
                textme7.text = rog17;
                string rog18 = myList9[0] + myList9[1] + myList9[2] + myList9[3] + myList9[4] + myList9[5] + myList9[6] + myList9[7] +
                myList9[8] + myList9[9] + myList9[10] + myList9[11] + "<color=red>" + myList9[12] + "</color>" + myList9[13] + myList9[14];
                textme8.text = rog18;
                entre9 = 1;
                etat10 = true;
            }
            else if (buttonText.text == "X" && etat10 == true)
            {
                etat10 = false;
                string rog19 = myList9[0] + myList9[1] + myList9[2] + myList9[3] + myList9[4] + myList9[5] + myList9[6] + myList9[7] +
                myList9[8] + myList9[9] + myList9[10] + myList9[11] + "<color=white>" + myList9[12] + "</color>" + myList9[13] + myList9[14];
                textme8.text = rog19;
                /*string rog20 = "<color=red>" + myList[0] + "</color>" + myList[1] + myList[2] + myList[3];
                textmesh.text = rog20;*/
                entre10 = 1;
                int res = entre1 + entre2 + entre3 + entre4 + entre5 + entre6 + entre7 + entre8 + entre9 + entre10;
                string resultat = res.ToString();
                print(resultat);
                resultatText.text = resultat;
                etat1 = false;
            }
            else
            {
                Past();
            }

         


            //Debug.Log(entre1 + entre2 + entre3 + entre4 + entre5 + entre6 + entre7 + entre8 + entre9 + entre10);
            // Erase/Display screen content
            if (buttonText.text == "Effacer")
                Clear();
            else
                Display();
        }

        public void Display()
        {
            screenText.text = buttonText.text;
        }

        public void Clear()
        {
            screenText.text = "En attente...";
        }
        public void Resclear()
        {
            resultatText.text = "En attente";
        }

        public void Past()
        {
            pass.onClick.Invoke();

            if (screenText.text == "Commencer")
            {
                Resclear();
                string rog = "<color=red>" + myList[0] + "</color>" + myList[1] + myList[2] + myList[3];
                textmesh.text = rog;
                screenText.text = "F";
                etat1 = true;


            }


            else if (screenText.text == "F" && etat1 == true)
            {
                etat1 = false;
                string rog1 = "<color=white>" + myList[0] + "</color>" + myList[1] + myList[2] + myList[3];
                textmesh.text = rog1;
                string rog2 = myList1[0] + myList1[1] + myList1[2] + "<color=red>" + myList1[3] + "</color>" + myList1[4] + myList1[5] + myList1[6];
                textme.text = rog2;
                //entre1 = 1;
                screenText.text = "O";
                etat2 = true;


            }
            else if (screenText.text == "O" && etat2 == true)
            {
                etat2 = false;
                string rog3 = myList1[0] + myList1[1] + myList1[2] + "<color=white>" + myList1[3] + "</color>" + myList1[4] + myList1[5] + myList1[6];
                textme.text = rog3;
                string rog4 = myList2[0] + myList2[1] + myList2[2] + "<color=red>" + myList2[3] + "</color>" + myList2[4] + myList2[5] + myList2[6] + myList2[7] + myList2[8] + myList2[9];
                textme1.text = rog4;
                // entre2 = 1;
                screenText.text = "P";

                etat3 = true;


            }
            else if (screenText.text == "P" && etat3 == true)
            {
                etat3 = false;
                string rog5 = myList2[0] + myList2[1] + myList2[2] + "<color=white>" + myList2[3] + "</color>" + myList2[4] + myList2[5] + myList2[6] + myList2[7] + myList2[8] + myList2[9];
                textme1.text = rog5;
                string rog6 = myList3[0] + myList3[1] + myList3[2] + myList3[3] + myList3[4] + myList3[5] + myList3[6] + myList3[7] +
                myList3[8] + myList3[9] + "<color=red>" + myList3[10] + "</color>";
                textme2.text = rog6;
                //entre3 = 1;
                screenText.text = "D";

                etat4 = true;


            }
            else if (screenText.text == "D" && etat4 == true)
            {
                etat4 = false;
                string rog7 = myList3[0] + myList3[1] + myList3[2] + myList3[3] + myList3[4] + myList3[5] + myList3[6] + myList3[7] +
                myList3[8] + myList3[9] + "<color=white>" + myList3[10] + "</color>";
                textme2.text = rog7;
                string rog8 = "<color=red>" + myList4[0] + "</color>" + myList4[1] + myList4[2] + myList4[3] + myList4[4] + myList4[5] + myList4[6] + myList4[7] +
                myList4[8] + myList4[9] + myList4[10];
                textme3.text = rog8;
                //entre4 = 1;
                screenText.text = "E";

                etat5 = true;

            }
            else if (screenText.text == "E" && etat5 == true)
            {
                etat5 = false;
                string rog9 = "<color=white>" + myList4[0] + "</color>" + myList4[1] + myList4[2] + myList4[3] + myList4[4] + myList4[5] + myList4[6] + myList4[7] +
                myList4[8] + myList4[9] + myList4[10];
                textme3.text = rog9;
                string rog10 = myList5[0] + myList5[1] + myList5[2] + myList5[3] + myList5[4] + myList5[5] + "<color=red>" + myList5[6] + "</color>" + myList5[7] +
                myList5[8] + myList5[9] + myList5[10] + myList5[11] + myList5[12];
                textme4.text = rog10;
                //entre5 = 1;
                screenText.text = "M";
                etat6 = true;

            }
            else if (screenText.text == "M" && etat6 == true)
            {
                etat6 = false;
                string rog11 = myList5[0] + myList5[1] + myList5[2] + myList5[3] + myList5[4] + myList5[5] + "<color=white>" + myList5[6] + "</color>" + myList5[7] +
                myList5[8] + myList5[9] + myList5[10] + myList5[11] + myList5[12];
                textme4.text = rog11;
                string rog12 = myList6[0] + myList6[1] + myList6[2] + myList6[3] + myList6[4] + myList6[5] + myList6[6] + myList6[7] +
                myList6[8] + myList6[9] + "<color=red>" + myList6[10] + "</color>" + myList6[11] + myList6[12] + myList6[13] + myList6[14];
                textme5.text = rog12;
                //entre6 = 1;
                screenText.text = "T";

                etat7 = true;

            }
            else if (screenText.text == "T" && etat7 == true)
            {
                etat7 = false;
                string rog13 = myList6[0] + myList6[1] + myList6[2] + myList6[3] + myList6[4] + myList6[5] + myList6[6] + myList6[7] +
                myList6[8] + myList6[9] + "<color=white>" + myList6[10] + "</color>" + myList6[11] + myList6[12] + myList6[13] + myList6[14];
                textme5.text = rog13;
                string rog14 = "<color=red>" + myList7[0] + "</color>" + myList7[1] + myList7[2] + myList7[3] + myList7[4] + myList7[5] + myList7[6] + myList7[7] +
                myList7[8] + myList7[9] + myList7[10] + myList7[11] + myList7[12] + myList7[13] + myList7[14];
                textme6.text = rog14;
                //entre7 = 1;
                screenText.text = "L";
                etat8 = true;
            }
            else if (screenText.text == "L" && etat8 == true)
            {
                etat8 = false;
                string rog15 = "<color=white>" + myList7[0] + "</color>" + myList7[1] + myList7[2] + myList7[3] + myList7[4] + myList7[5] + myList7[6] + myList7[7] +
                myList7[8] + myList7[9] + myList7[10] + myList7[11] + myList7[12] + myList7[13] + myList7[14];
                textme6.text = rog15;
                string rog16 = myList8[0] + myList8[1] + myList8[2] + myList8[3] + myList8[4] + myList8[5] + myList8[6] + myList8[7] +
                myList8[8] + myList8[9] + myList8[10] + myList8[11] + myList8[12] + myList8[13] + "<color=red>" + myList8[14] + "</color>";
                textme7.text = rog16;
                //entre8 = 1;
                screenText.text = "Q";
                etat9 = true;

            }

            else if (screenText.text == "Q" && etat9 == true)
            {
                etat9 = false;
                string rog17 = myList8[0] + myList8[1] + myList8[2] + myList8[3] + myList8[4] + myList8[5] + myList8[6] + myList8[7] +
                myList8[8] + myList8[9] + myList8[10] + myList8[11] + myList8[12] + myList8[13] + "<color=white>" + myList8[14] + "</color>";
                textme7.text = rog17;
                string rog18 = myList9[0] + myList9[1] + myList9[2] + myList9[3] + myList9[4] + myList9[5] + myList9[6] + myList9[7] +
                myList9[8] + myList9[9] + myList9[10] + myList9[11] + "<color=red>" + myList9[12] + "</color>" + myList9[13] + myList9[14];
                textme8.text = rog18;
                //entre9 = 1;
                screenText.text = "X";
                etat10 = true;
            }
            else if (screenText.text == "X" && etat10 == true)
            {
                etat10 = false;
                string rog19 = myList9[0] + myList9[1] + myList9[2] + myList9[3] + myList9[4] + myList9[5] + myList9[6] + myList9[7] +
                myList9[8] + myList9[9] + myList9[10] + myList9[11] + "<color=white>" + myList9[12] + "</color>" + myList9[13] + myList9[14];
                textme8.text = rog19;
                /*string rog20 = "<color=red>" + myList[0] + "</color>" + myList[1] + myList[2] + myList[3];
                textmesh.text = rog20;*/
                //entre10 = 1;
                int res = entre1 + entre2 + entre3 + entre4 + entre5 + entre6 + entre7 + entre8 + entre9 + entre10;
                string resultat = res.ToString();
                print(resultat);
                resultatText.text = resultat;
                etat1 = false;
            }

        }
    }
}
