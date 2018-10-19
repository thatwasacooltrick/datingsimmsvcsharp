using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TristianDatingSimulator
{
    public partial class frmDate : Form
    {


        static string id = null;

        public frmDate()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            getText("start");
        }
    

        private void btnA_Click(object sender, EventArgs e)
        {
            nextTurn("A");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            nextTurn("B");
        }

        private void nextTurn(string SentButton) {
            switch (id) {
                case "00000":
                        if(SentButton == "A"){
                        getText("sithere");
                        }else if(SentButton == "B"){
                        getText("urcute");
                        }
                        break;
                case "A0000":
                    if (SentButton == "A"){
                    getText("awk");
                    } else if (SentButton == "B"){
                    getText("thanks");
                    }
                    break;
        }

        }
        //This is organized in a branching tree. Think /\ SORTA DEALIO
        private void getText(string text) {
            switch (text){
                case "start":
                    id = "00000";
                    txtOut.Text = "Ever since you first met him you were in love with this mouse. He's a quirky fellow";
                    btnA.Text = "Hiya";
                    btnB.Text = "EEP!";
                    break;
                case "sithere":
                    id = "A0000";
                    txtOut.Text = "Hey, mind if I sit here, cutie?";
                    btnA.Text = "Kinda..";
                    btnB.Text = "No, you're fine";
                    break;
                case "urcute":
                    id = "B0000";
                    txtOut.Text = "Oh sorry, I guess you're as shy as I thought. Cute";
                    btnA.Text = "HEY! I'm not that shy *Blush*";
                    btnB.Text = "EEP!";
                    break;
                case "awk":
                    //GAMEOVER
                    id = "AA000";
                    txtOut.Text = "Oh, I understand";
                    btnA.Text = "0//_//0";
                    btnA.Enabled = false;
                    btnB.Text = "(Game Over)";
                    btnB.Enabled = false;
                    break;
                case "thanks":
                    id = "AB000";
                    txtOut.Text = "Thanks! *He sits*";
                    btnA.Text = "Why do you want to sit with me?";
                    btnB.Text = "";
                    break;
                default:
                    id = "404";
                    txtOut.Text = "Hey, sweetie, this section hasn't been added yet";
                    btnA.Text = "Sit quietly and masturbate";
                    btnB.Text = "Send an email to thatwasacooltrick@gmail.com";
                    break;
                    
            }

        }

        private void txtOut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
