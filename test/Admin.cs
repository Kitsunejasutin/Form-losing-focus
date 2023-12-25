using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
  public partial class Admin : Form
  {
    private LoadingAlert la = null;
    private Form frm;
    public Admin(Form frm)
    {
      InitializeComponent();
      this.frm = frm;
    }

    private async void Admin_Load(object sender, EventArgs e)
    {
      la = new LoadingAlert("LOADING COMPANIES");
      la.Show(this);
      frm.Enabled = false;
      Enabled = false;
      await Task.Delay(100);
      frm.Enabled = true;
      Enabled = true;
      la.Close();
    }
  }
}
