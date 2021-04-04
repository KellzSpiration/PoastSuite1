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
        public GradePageQ3(string score5)
        {
            InitializeComponent();
            lblGrade.Text = score5 + "%"; 
        }
    }
}