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
        public GradePageQ2(string score5)
        {
            InitializeComponent();
            lblGrade.Text = score5 + "%";
        }
    }
}