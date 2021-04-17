using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastVOne.QuestionFour
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GradePageQ4 : ContentPage
    {
        protected override bool OnBackButtonPressed() => false;

        private double s;
        public GradePageQ4(double score5)
        {
            InitializeComponent();
            
        }

        private void ReviewAndGrade_Clicked(object sender, EventArgs e)
        {
            UserScore.Text = s + "%";
        }

       async private void ExitHJModule_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationQ4());
        }
    }
}