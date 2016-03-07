using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTextWriter
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void txtText_TextChanged(object sender, EventArgs e)
    {
      var btext = getBinaryText(txtText.Text);
      if (!txtBinary.Text.Equals(btext))
        txtBinary.Text = btext;
    }

    private string getBinaryText(string input)
    {
      var output = new StringBuilder();
      foreach (var c in Encoding.ASCII.GetBytes(input))
      {
        output.Append("0" + Convert.ToString(c, 2) + " ");
      }

      return output.ToString();
    }

    private string getTextFromBinaryString(string input)
    {
      var output = new List<Byte>();
      var bytes = input.Split(new[]{' '}, StringSplitOptions.RemoveEmptyEntries);
      foreach (var b in bytes)
      {
        output.Add(Convert.ToByte(b, 2));
      }

      return Encoding.ASCII.GetString(output.ToArray());
    }

    private void txtBinary_TextChanged(object sender, EventArgs e)
    {
      if (txtBinary.Text.Replace(" ", "").Length%8 == 0)
      {
        var text = getTextFromBinaryString(txtBinary.Text);
        if (!text.Equals(txtText.Text))
          txtText.Text = text;
        txtBinary.SelectionStart = txtBinary.Text.Length == 0 ? 0 : txtBinary.Text.Length-1;
        txtBinary.SelectionLength = 0;
      }
    }
  }
}
