using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GeminiWinForms_2;
public partial class Form1 : Form
{
    GeminiService servicio = new GeminiService();

    public Form1()
    {
        InitializeComponent();

        txtInput.KeyDown += txtInput_KeyDown;
    }

    private async Task EnviarMensaje()
    {
        string mensaje = txtInput.Text;

        if (string.IsNullOrWhiteSpace(mensaje))
            return;

        txtChat.AppendText("Tú:\r\n" + mensaje + "\r\n\r\n");
        txtInput.Clear();

        try
        {
            string respuesta = await servicio.EnviarPrompt(mensaje);
            respuesta = FormatearTexto(respuesta);

            txtChat.AppendText("Gemini:\r\n" + respuesta + "\r\n\r\n");
        }
        catch (Exception ex)
        {
            txtChat.AppendText("Error: " + ex.Message + Environment.NewLine);
        }
    }
    private string FormatearTexto(string texto)
    {
        texto = texto.Replace("**", "");
        texto = texto.Replace(". ", ".\r\n");

        texto = texto.Replace("1.", "\r\n1.");
        texto = texto.Replace("2.", "\r\n2.");
        texto = texto.Replace("3.", "\r\n3.");
        texto = texto.Replace("4.", "\r\n4.");

        return texto;
    }

    private async void btnEnviar_Click(object sender, EventArgs e)
    {
        await EnviarMensaje();
    }

    private async void txtInput_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter && !e.Shift)
        {
            e.SuppressKeyPress = true;
            await EnviarMensaje();
        }
    }
}