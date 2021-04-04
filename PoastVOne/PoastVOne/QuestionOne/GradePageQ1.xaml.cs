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
        public GradePageQ1(string score5)
        {
            InitializeComponent();
            lblGrade.Text = score5 + "%";
        }
    }
}