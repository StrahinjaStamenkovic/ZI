using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace A51
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox tbxKey;
		private System.Windows.Forms.Button btnCrypt;
		private System.Windows.Forms.TextBox tbxSource;
		private System.Windows.Forms.TextBox tbxEnd;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			
			
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCrypt = new System.Windows.Forms.Button();
			this.tbxKey = new System.Windows.Forms.TextBox();
			this.tbxSource = new System.Windows.Forms.TextBox();
			this.tbxEnd = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCrypt
			// 
			this.btnCrypt.Location = new System.Drawing.Point(576, 24);
			this.btnCrypt.Name = "btnCrypt";
			this.btnCrypt.TabIndex = 0;
			this.btnCrypt.Text = "Crypt";
			this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
			// 
			// tbxKey
			// 
			this.tbxKey.Location = new System.Drawing.Point(24, 24);
			this.tbxKey.Name = "tbxKey";
			this.tbxKey.Size = new System.Drawing.Size(392, 20);
			this.tbxKey.TabIndex = 1;
			this.tbxKey.Text = "1111000011110000111100001111000011110000111100001111000011110000";
			// 
			// tbxSource
			// 
			this.tbxSource.Location = new System.Drawing.Point(32, 72);
			this.tbxSource.Multiline = true;
			this.tbxSource.Name = "tbxSource";
			this.tbxSource.Size = new System.Drawing.Size(528, 88);
			this.tbxSource.TabIndex = 2;
			this.tbxSource.Text = "";
			// 
			// tbxEnd
			// 
			this.tbxEnd.Location = new System.Drawing.Point(32, 176);
			this.tbxEnd.Multiline = true;
			this.tbxEnd.Name = "tbxEnd";
			this.tbxEnd.Size = new System.Drawing.Size(528, 88);
			this.tbxEnd.TabIndex = 3;
			this.tbxEnd.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(712, 273);
			this.Controls.Add(this.tbxEnd);
			this.Controls.Add(this.tbxSource);
			this.Controls.Add(this.tbxKey);
			this.Controls.Add(this.btnCrypt);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnCrypt_Click(object sender, System.EventArgs e)
		{
			A51class a51 = new A51class(this.tbxKey.Text);
			this.tbxEnd.Text = a51.Crypt(this.tbxSource.Text);			
		}

		
		        		
	}
}
