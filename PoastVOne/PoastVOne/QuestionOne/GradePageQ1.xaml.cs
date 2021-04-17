using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastVOne.QuestionOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GradePageQ1 : ContentPage
    {
        protected override bool OnBackButtonPressed() => false;

        private double s;
        public GradePageQ1(double score5)
        {
            InitializeComponent();
           s = score5;
        }

        private void ReviewAndGrade_Clicked(object sender, EventArgs e)
        {
            UserScore.Text = s + "%".ToString();
        }

       async private void ExitHJModule_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationQ1());
        }
    }
}