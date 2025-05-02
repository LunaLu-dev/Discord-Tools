using System.Text.Json;

namespace Discord_Tools;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public class DiscordResponse
    {
        public string message { get; set; }
        public int code { get; set; }
    }

    private static HttpClient sharedClient = new()
        { };

    private async void Submit_Click(object sender, EventArgs e)
    {
        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                $"https://discord.com/api/v9/guilds/{ServerIdInput.Text}/widget.json");

            var response =
                await sharedClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Server ID Exist");
                return;
            }

            var json = await response.Content.ReadAsStringAsync();

            DiscordResponse? discordResponse =
                JsonSerializer.Deserialize<DiscordResponse>(json);

            if (discordResponse?.code == 50004)
            {
                MessageBox.Show("Server ID Exist");
            }
            else if (discordResponse?.code == 10004)
            {
                MessageBox.Show("Server ID does not exist");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}