﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lashon2
{
    public partial class gizra : System.Web.UI.Page
    {
        public int startTime;
        public Random rand = new Random();
        public int timer = 0;
        string question;

        public static string[] sentece = File.ReadAllLines(@"F:\לשון\lashon2\lashon2\GizraWords.txt");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {





                int nextSentence;
                do
                {
                    nextSentence = rand.Next(0, sentece.Length);

                } while (nextSentence % 2 != 0);
                int[] usedQuestion = new int[6];
                usedQuestion[0] = nextSentence;
                Session["usedQuestion"] = usedQuestion;
                LblSentence.Text = sentece[nextSentence];
                Session["question"] = sentece[nextSentence];
            }
        }


        protected void btnCheck(object sender, EventArgs e)
        {
            int[] usedQuestion = (int[])Session["usedQuestion"];
            question = (string)Session["question"];
            int i = Array.IndexOf(sentece, question),
                nextSentence;

            if (TxtAnswer.Text == sentece[i + 1])
            {
                int score = int.Parse(LblScore.Text);
                score++;
                LblScore.Text = score.ToString();

            }
            TxtAnswer.Text = "";
            do
            {
                nextSentence = rand.Next(0, sentece.Length);

            } while (nextSentence % 2 != 0 || !LabelChange(nextSentence));
            usedQuestion[int.Parse(LblRepeat.Text)] = nextSentence;
            LblSentence.Text = sentece[nextSentence];
            Session["question"] = sentece[nextSentence];
            LblRepeat.Text = (int.Parse(LblRepeat.Text) + 1).ToString();
            Session["usedQuestion"] = usedQuestion;
            if (LblRepeat.Text == "5")
            {
                Session["score"] = LblScore.Text;
                LblRepeat.Text = "0";
                LblUsedQuestion.Text = "0";
                LblRepeat.Text = "0";
                Response.Redirect("score.aspx");
            }
        }

        protected bool LabelChange(int adder)
        {
            int[] usedQustion = (int[])Session["usedQuestion"];
            for(int i=0;i<usedQustion.Length;i++)
            {
                if (usedQustion[i] == adder)
                    return false;
            }
            return true;
        }
    }
}