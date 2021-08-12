using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastVOne.QuestionEight
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GradePageQ8 : ContentPage
    {
        private double s;
        public GradePageQ8(double score5)
        {
            InitializeComponent();
            s = score5;
        }

       async private void ExitHJModule_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationQ8());
        }

        private void ReviewAndGrade_Clicked(object sender, EventArgs e)
        {
            UserScore.Text = s + "%".ToString();
        }
    }
}