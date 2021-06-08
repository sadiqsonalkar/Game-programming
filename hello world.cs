using System;
using System.Collections.Generic; using System.ComponentModel; using System.Data;
using System.Drawing; using System.Linq; using System.Text;
using System.Windows.Forms; using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace gameprac1
{
public partial class Form1 : Form
{
private Device device = null; public Form1()
{
InitializeComponent(); InitDevice();
}
public void InitDevice()
{
PresentParameters pp = new PresentParameters(); pp.Windowed = true;
pp.SwapEffect = SwapEffect.Discard;
device = new Device(0, DeviceType.Reference, this, CreateFlags.SoftwareVertexProcessing, pp);
}
protected override void OnPaint(PaintEventArgs e)
{
//Clear the backbuffer to a yellowgreen color device.Clear(ClearFlags.Target, Color.Yellowgreen, 0, 1); device.Present();
}
private void Form1_Load(object sender, EventArgs e)
{
 

}
}
}
