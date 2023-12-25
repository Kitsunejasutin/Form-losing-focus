using System;
using System.Windows.Forms;

namespace test
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Admin frm = new Admin(this);
      LoadPanel(frm);
    }

    private void LoadPanel(Form newForm)
    {
      newForm.Dock = DockStyle.Fill;
      newForm.TopLevel = false;
      panelContainer.Controls.Clear();
      panelContainer.Controls.Add(newForm);
      newForm.Show();
    }
  }
}
