using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastVOne.QuestionThree
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GradePageQ3 : ContentPage
    {
        protected override bool OnBackButtonPressed() => false;
        
        private double s;
        public GradePageQ3(double score5)
        {
            InitializeComponent();
            s = score5; 
        }

       async private void ExitHJModule_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationQ3()); 
        }

        private void ReviewAndGrade_Clicked(object sender, EventArgs e)
        {
            UserScore.Text = s + "%";
        }
    }
}