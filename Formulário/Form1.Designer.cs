namespace Formulário;
using Npgsql;
partial class Form1 : Form
{
    private TextBox textBox1;
    private TextBox textBox2;
    private Bitmap Login;
    private Label label1;
    private Label label2;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private Button button1;

    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
     public async void connect()
    {

        var connectionString = "Host=localhost;Port5432;Username=postgres;Password=Daniel12;Database=Formulario;";
        await using var dataSource = NpgsqlDataSource.Create(connectionString);

        // Insert some data
       await using (var cmd = dataSource.CreateCommand("INSERT INTO data (Formulario.verificacãoFormulario) VALUES ($1)"))
        {
            cmd.Parameters.AddWithValue("Hello world");
            await cmd.ExecuteNonQueryAsync();
        }
        // Retrieve all rows
        /*await using (var cmd = dataSource.CreateCommand("SELECT some_field FROM data"))
        await using (var reader = await cmd.ExecuteReaderAsync())
        {
            while (await reader.ReadAsync())
            {
                Console.WriteLine(reader.GetString(0));
            }
        }*/
    }
    private void InitializeComponent()
    {
        this.connect();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.pictureBox2 = new System.Windows.Forms.PictureBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.button1 = new System.Windows.Forms.Button();

        this.SuspendLayout();
        this.pictureBox1.Location = new Point(3, 0);
        pictureBox1.Size = new Size(320, 300);
        this.pictureBox1.Image = Image.FromFile("login.png");

        //Definições labeel1
        this.label1.Text = " Digite o seu email ";
        this.label1.Size = new Size(200, 20);
        this.label1.Location = new Point(20, 300);

        //Definições label2
        this.label2.Text = " Digite a sua senha ";
        this.label2.Size = new Size(200, 20);
        this.label2.Location = new Point(20, 350);

        //Definições da button1
        this.button1.Text = " Logar ";
        this.button1.Size = new Size(200, 50);
        this.button1.Location = new Point(10, 440);
        this.button1.Click += (sender, args) =>
        {
            if (this.textBox1.Text == "danielpython3@gmail.com" && this.textBox2.Text == "Daniel12")
            {
                MessageBox.Show(" Dados válidos");
                //this.Messagebox.Size = new Size(200, 50);
                //this.Messagebox.Location = new Point(10, 440);
            }
            else
            {
                MessageBox.Show(" Dados inválidos ");
            }
        };

        //Definições da textbox1
        this.textBox1.Size = new Size(220, 40);
        this.textBox1.Location = new Point(2, 320);

        //Definições da textbox2
        this.textBox2.Size = new Size(220, 40);
        this.textBox2.Location = new Point(2, 370);

        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(230, 500);
        this.Controls.Add(pictureBox1);
        this.Controls.Add(pictureBox2);
        this.Controls.Add(label1);
        this.Controls.Add(label2);
        this.Controls.Add(textBox1);
        this.Controls.Add(textBox2);
        this.Controls.Add(button1);

        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(230, 500);
        this.Text = "Formulário";
    }
    
    #endregion
}
