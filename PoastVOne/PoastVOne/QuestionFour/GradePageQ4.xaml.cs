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
        public GradePageQ4(string score5)
        {
            InitializeComponent();
            lblGrade.Text = score5 + "%";
        }
    }
}