using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PoastVOne.QuestionOne;
using PoastVOne.QuestionTwo;
using PoastVOne.QuestionThree;
using PoastVOne.QuestionFour;
using PoastVOne.QuestionFive;
using PoastVOne.QuestionSix;
using PoastVOne.QuestionSeven;
using PoastVOne.QuestionEight;
using PoastVOne.QuestionNine;
using PoastVOne.QuestionTen;

namespace PoastVOne
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FirstIterationQ1());
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FirstIterationQ2());
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FirstIterationQ3());
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FirstIterationQ4());
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FirstIterationQ5());
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FirstIterationQ6());
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FirstIterationQ7());
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FirstIterationQ8());
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FirstIterationQ9());
        }

        private void Btn10_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FirstIterationQ10());
        }
    }
}
