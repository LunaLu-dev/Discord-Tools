using System.Drawing.Text;
using System.Net.Http;


namespace Discord_Tools;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // It's best to create HttpClient as a static/singleton instance
    private static readonly HttpClient client = new HttpClient();
    
    

    
    private async void Submit_Click(object sender, EventArgs e)
    {

       


    }
    
    
}