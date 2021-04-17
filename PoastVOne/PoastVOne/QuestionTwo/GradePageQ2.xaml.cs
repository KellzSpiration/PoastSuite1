using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastVOne.QuestionTwo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GradePageQ2 : ContentPage
    {
        protected override bool OnBackButtonPressed() => false;

        private double s;
        public GradePageQ2(double score5)
        {
            InitializeComponent();
            s = score5;
        }

        private void ReviewAndGrade_Clicked(object sender, EventArgs e)
        {
            UserScore.Text = s + "%".ToString();
        }

      async  private void ExitHJModule_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationQ2());
        }
    }
}