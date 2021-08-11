using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lashon2
{
    public partial class different : System.Web.UI.Page
    {
        public Random rand = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SubjectPick();
                PrintQuestion();


            }
        }


        protected void btnCheck(object sender, EventArgs e)
        {
            string[] sentece = (string[])Session["sentece"];
            string question = (string)Session["question"];
            int rightAnser = (int)Session["rightAnser"];

            try
            {
                int.Parse(TxtAnswer.Text);
            }
            catch (Exception ex)
            {
                return;
            }
            if (int.Parse(TxtAnswer.Text) == rightAnser)
            {
                int score = int.Parse(LblScore.Text);
                score++;
                LblScore.Text = score.ToString();

            }
            TxtAnswer.Text = "";


            LblRepeat.Text = (int.Parse(LblRepeat.Text) + 1).ToString();
            if (LblRepeat.Text == "5")
            {
                Session["score"] = LblScore.Text;
                LblRepeat.Text = "0";
                LblUsedQuestion.Text = "";
                Response.Redirect("score.aspx");
            }
            SubjectPick();

        }

        protected bool LabelChange(int adder)
        {
            int[] usedQustion = (int[])Session["usedQuestion"];
            for (int i = 0; i < usedQustion.Length; i++)
            {
                if (usedQustion[i] == adder)
                    return false;
            }
            return true;
        }
        protected string SentencePick(string wordFamily)
        {
            string[] sentece = (string[])Session["sentece"];
            int nextSentence;
            do
            {
                nextSentence = rand.Next(0, sentece.Length);

            } while (nextSentence % 2 != 0 || sentece[nextSentence + 1] != wordFamily);
            LblUsedQuestion.Text = LblUsedQuestion.Text + nextSentence;
            return sentece[nextSentence];
        }
        protected string PickCommon()
        {
            string[] options = (string[])Session["options"];
            string common = options[rand.Next(0, options.Length - 1)];
            Session["common"] = common;
            return common;
        }
        protected string PickDiffrent()
        {
            string[] options = (string[])Session["options"];
            string diffrent;
            do
            {
                diffrent = options[rand.Next(0, options.Length - 1)];
                Session["diffrent"] = diffrent;
            } while (diffrent == (string)Session["common"]);

            return diffrent;
        }
        protected void PrintQuestion()
        {
            int whichWrong = rand.Next(0, 4),
                rightAnswer;
            string common = PickCommon(),
                   diffrent = PickDiffrent(),
                   right1 = SentencePick(common),
                   right2 = SentencePick(common),
                   right3 = SentencePick(common),
                   diffrentAnswer = SentencePick(diffrent),
                   sentence;

            switch (whichWrong)
            {
                case 0:
                    rightAnswer = 4;
                    sentence = string.Format("1:{0}\n2:{1}\n3:{2}\n4:{3}", right1, right2, right3, diffrentAnswer);
                    break;
                case 1:
                    sentence = string.Format("1:{0}\n2:{1}\n3:{2}\n4:{3}", right1, right2, diffrentAnswer, right3);
                    rightAnswer = 3;
                    break;
                case 2:
                    sentence = string.Format("1:{0}\n2:{1}\n3:{2}\n4:{3}", right1, diffrentAnswer, right3, right2);
                    rightAnswer = 2;
                    break;
                default:
                    sentence = string.Format("1:{0}\n2:{1}\n3:{2}\n4:{3}", diffrentAnswer, right2, right3, right1);
                    rightAnswer = 1;
                    break;
            }
            Session["rightAnser"] = rightAnswer;
            LblSentence.Text = sentence;
        }
        protected void SubjectPick()
        {
            int array =rand.Next(1, 3);
            if (array == 1)
            {
                string[] sentece = File.ReadAllLines(@"F:\לשון\lashon2\lashon2\GizraWords.txt");
                Session["sentece"] = sentece;
                string[] options = File.ReadAllLines(@"F:\לשון\lashon2\lashon2\Gizrot.txt");
                Session["options"] = options;
            }
            else
            {
                string[] sentece = File.ReadAllLines(@"F:\לשון\lashon2\lashon2\BasesWords.txt");
                Session["sentece"] = sentece;
                string[] options = File.ReadAllLines(@"F:\לשון\lashon2\lashon2\Bases.txt");
                Session["options"] = options;
            }
            PrintQuestion();
        }


    }
}